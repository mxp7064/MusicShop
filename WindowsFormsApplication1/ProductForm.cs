using MusicShop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MusicShop
{
    public partial class ProductForm : Form
    {
        private product product;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            product = this.Tag as product;

            object image = Resources.ResourceManager.GetObject(product.productCover);
            coverPictureBox.Image = (Image)image;

            if (MusicShopBL.IncludeProductDetails(product) == false)
            {
                MessageBox.Show("Product can't be loaded!");
                return;
            }

            productBindingSource.DataSource = product;
            if (product.genre != null)
                genreBindingSource.DataSource = product.genre;
            else
                genrePanel.Visible = false;
            creatorBindingSource.DataSource = product.productcreators.Select(x => x.creator);
            producttypeBindingSource.DataSource = product.producttype;

            creatorListBox_SelectedIndexChanged(creatorListBox, new EventArgs());

            if (product.isDiscounted == true)
            {
                discountRateLabel.Visible = true;
                discountRateLabel.Text = "-" + product.discountRate + "%";
                oldPriceLabel.Visible = true;
                oldPriceLabel.Text = "$" + product.productPrice;
                priceLabel.Text = "$" + (product.productPrice - (product.productPrice * product.discountRate / 100));
            }
            else
            {
                priceLabel.Text = "$" + product.productPrice;
            }

            MyLoad();
        }

        public void MyLoad()
        {
            commentsPanel.Controls.Clear();

            if (product.ratings.Count > 0)
            {
                foreach (rating rating in product.ratings)
                {
                    string userName = rating.user.userName;
                    Label userLabel = new Label { Font = new Font("Arial", 13), Text = userName, AutoSize = true };
                    userLabel.Dock = System.Windows.Forms.DockStyle.Bottom;

                    int? grade = rating.ratingGrade;
                    PictureBox gradePicture = new PictureBox { Padding = new Padding(0), Margin = new Padding(5, 0, 0, 0) };

                    gradePicture.Size = new System.Drawing.Size(100, 21);
                    gradePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    gradePicture.Image = (Image)Resources.ResourceManager.GetObject("star" + grade);

                    FlowLayoutPanel nameGradePanel = new FlowLayoutPanel { Margin = new Padding(0, 0, 0, 10) };
                    nameGradePanel.FlowDirection = FlowDirection.LeftToRight;
                    nameGradePanel.AutoSize = true;
                    nameGradePanel.Controls.Add(userLabel);
                    nameGradePanel.Controls.Add(gradePicture);

                    Label commentLabel = new Label { Font = new Font("Arial", 10), Text = rating.comment, AutoSize = true };

                    FlowLayoutPanel ratingPanel = new FlowLayoutPanel { Margin = new Padding(0, 10, 0, 10) };
                    ratingPanel.FlowDirection = FlowDirection.TopDown;
                    ratingPanel.AutoSize = true;
                    ratingPanel.Controls.Add(nameGradePanel);
                    ratingPanel.Controls.Add(commentLabel);

                    commentsPanel.Controls.Add(ratingPanel);
                }
            }
            else
            {
                commentsPanel.Controls.Add(new Label { Font = new Font("Arial", 15), Text = "No comments", AutoSize = true, Margin = new Padding(200, 0, 0, 10) });
            }

            commentsPanel.Padding = new Padding(0, 0, 0, 200);

            if (MusicShopPage.IsLoggedIn)
            {
                loginToPostLabel.Visible = false;
                postCommentButton.Visible = true;
                leaveCommentLabel.Visible = true;
                gradeComboBox.Visible = true;
                gradeComboBox.SelectedIndex = 4;
                commenctTextBox.Visible = true;
                gradeLabel.Visible = true;
                loginButton.Visible = false;
                registerButton.Visible = false;
            }
            else
            {
                loginToPostLabel.Visible = true;
                postCommentButton.Visible = false;
                leaveCommentLabel.Visible = false;
                gradeComboBox.Visible = false;
                commenctTextBox.Visible = false;
                gradeLabel.Visible = false;
                loginButton.Visible = true;
                registerButton.Visible = true;
            }
        }
        private void creatorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            creator c = lb.SelectedItem as creator;
            if (c == null) return;
            creatorDescriptionLabel.Text = c.creatorDescription;
            creatorRoleLabel.Text = product.productcreators.Single(x => x.creatorID == c.creatorID).creatorRole;
        }

        private void postCommentButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            string comment = commenctTextBox.Text;
            int grade = Convert.ToInt32(gradeComboBox.SelectedItem.ToString());
            user user = MusicShopPage.User;

            if (MusicShopBL.InsertNewRating(new rating { user = user, comment = comment, ratingGrade = grade, product = product }))
            {
                MessageBox.Show("Comment posted!");
                MyLoad();
                return;
            }

            MessageBox.Show("Can not post comment!");

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserLoginForm ulf = new UserLoginForm();
            ulf.Tag = this;
            ulf.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm urf = new UserRegisterForm();
            urf.Tag = this;
            urf.Show();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (!MusicShopPage.IsLoggedIn)
            {
                MessageBox.Show("You must login to buy products!");
                return;
            }

            bool doesExistInCart = MusicShopBL.InsertProductIntoCart(product, MusicShopPage.User);
            if (doesExistInCart)
            {
                MessageBox.Show("This product is already in your cart!");
                return;
            }

            if (MessageBox.Show("Product " + product.productName + " added to your cart!\nDo you want to open your cart now?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CartForm cf = new CartForm();
                cf.Show();
            }
        }
    }
}
