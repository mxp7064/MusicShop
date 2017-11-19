using MusicShop;
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

namespace WindowsFormsApplication1
{
    public partial class MusicShopPage : Form
    {
        List<product> products = new List<product>();
        private List<string> genres;
        public static MusicShopPage msp;

        public static bool IsLoggedIn = false;
        public static user User;
        string prodType = "";

        double fromPrice = 0;
        double toPrice = 0;

        private int page = 1;
        private int pageCount;
        private int numOfRes;

        public MusicShopPage()
        {
            InitializeComponent();
            msp = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double.TryParse(priceRangeFromTB.Text, out fromPrice);
            double.TryParse(priceRangeToTB.Text, out toPrice);
            genres = MusicShopBL.GetGenres();
            foreach (var genre in genres)
            {
                genreCheckedListBox.Items.Add(genre);
            }

            for (int i = 0; i < genreCheckedListBox.Items.Count; i++)
            {
                genreCheckedListBox.SetItemChecked(i, true);
            }

            List<string> prodTypes = MusicShopBL.GetProductTYpes();
            prodTypes.Insert(0, "ALL");
            productTypeComboBox.DataSource = prodTypes;
            LoadProducts(1);
        }

        public void LoadProducts(int p)
        {
            products = MusicShopBL.GetProducts(prodType, genres, fromPrice, toPrice, p, out pageCount, out numOfRes);
            page = p;
            RefreshProducts();
            UpdatePageTextBox();
            numOfResLabel.Text = "Number of results: " + numOfRes;
        }

        private void RefreshProducts()
        {
            this.ActiveControl = null;
            bigPanel.Controls.Clear();

            lastPageLabel.Text = "..." + pageCount;

            FlowLayoutPanel twoProductsPanel = new FlowLayoutPanel();
            twoProductsPanel.FlowDirection = FlowDirection.LeftToRight;
            twoProductsPanel.AutoSize = true;

            if (products.Count == 0)
            {
                noResultsLabel.Visible = true;
                return;
            }

            noResultsLabel.Visible = false;
            for (int i = 0; i < products.Count; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.AutoSize = true;

                PictureBox pb = new PictureBox();
                object image = Resources.ResourceManager.GetObject(products[i].productCover);
                pb.Image = (Image)image;
                pb.Size = new System.Drawing.Size(600, 225);
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                panel.Controls.Add(pb);

                TableLayoutPanel namePricePanel = new TableLayoutPanel();
                namePricePanel.Size = new System.Drawing.Size(550, 35); 
                namePricePanel.RowCount = 1;
                

                Label nameLabel = new Label();
                nameLabel.Font = new Font("Arial", 15, FontStyle.Bold);
                nameLabel.Cursor = Cursors.Hand;
                nameLabel.Text = products[i].productName;
                nameLabel.AutoSize = true;
                nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
                namePricePanel.Controls.Add(nameLabel, 0, 0);
                nameLabel.Tag = products[i];
                
                nameLabel.Click += new EventHandler(NameLabelClick);
                nameLabel.MouseEnter += new System.EventHandler(NameLabelEnter);
                nameLabel.MouseLeave += new System.EventHandler(NameLabelLeave);

                if (products[i].isDiscounted == true)
                {
                    namePricePanel.ColumnCount = 4;
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.5F));
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));

                    Label oldPriceLabel = new Label ();
                    oldPriceLabel.Font = new Font("Arial", 15, FontStyle.Strikeout);
                    oldPriceLabel.Text = "$" + products[i].productPrice;
                    namePricePanel.Controls.Add(oldPriceLabel, 1, 0);

                    Label discountLabel = new Label { BackColor = Color.Red};
                    discountLabel.ForeColor = Color.White;
                    discountLabel.Font = new Font("Arial", 15, FontStyle.Regular);
                    discountLabel.Text = "-" + products[i].discountRate + "%";
                    namePricePanel.Controls.Add(discountLabel, 2, 0);

                    Label newPriceLabel = new Label ();
                    newPriceLabel.Font = new Font("Arial", 15, FontStyle.Bold);
                    newPriceLabel.Text = "$" + (products[i].productPrice - products[i].productPrice* products[i].discountRate/100);
                    namePricePanel.Controls.Add(newPriceLabel, 3, 0);
                }
                else
                {
                    namePricePanel.ColumnCount = 2;
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
                    namePricePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                    Label priceLabel = new Label();
                    priceLabel.Font = new Font("Arial", 15, FontStyle.Bold);
                    priceLabel.AutoSize = true;
                    priceLabel.Text = "$" + products[i].productPrice;
                    priceLabel.Dock = System.Windows.Forms.DockStyle.Right;
                    namePricePanel.Controls.Add(priceLabel, 1, 0);
                    
                }

                panel.Controls.Add(namePricePanel);

                TableLayoutPanel typeGenrePanel = new TableLayoutPanel();
                typeGenrePanel.Size = new System.Drawing.Size(550, 35);
                typeGenrePanel.RowCount = 1;
                typeGenrePanel.ColumnCount = 2;
                typeGenrePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                typeGenrePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                Label productTypeLabel = new Label();
                productTypeLabel.Font = new Font("Arial", 14);
                productTypeLabel.AutoSize = true;
                productTypeLabel.Text = "Type: " + products[i].producttype.productTypeName;
                typeGenrePanel.Controls.Add(productTypeLabel);

                if (products[i].genre != null)
                {
                    Label genreLabel = new Label();
                    genreLabel.Font = new Font("Arial", 14);
                    genreLabel.AutoSize = true;
                    genreLabel.Text = "Genre: " + products[i].genre.genreName;
                    genreLabel.Dock = System.Windows.Forms.DockStyle.Right;
                    typeGenrePanel.Controls.Add(genreLabel);
                }
                
                panel.Controls.Add(typeGenrePanel);

                if (i % 2 == 0 && i > 0)
                {
                    twoProductsPanel = new FlowLayoutPanel();
                    twoProductsPanel.FlowDirection = FlowDirection.LeftToRight;
                    twoProductsPanel.AutoSize = true;
                }

                twoProductsPanel.Controls.Add(panel);

                if (!bigPanel.Contains(twoProductsPanel))
                    bigPanel.Controls.Add(twoProductsPanel);
            }


            this.Controls.Add(bigPanel);
        }

        void NameLabelClick(object sender, EventArgs e)
        {
            Label nameLabel = sender as Label;
            if (nameLabel != null)
            {
                ProductForm pf = new ProductForm();
                pf.Tag = nameLabel.Tag;
                pf.Show();
            }
        }

        void NameLabelEnter(object sender, EventArgs e)
        {
            Label nameLabel = sender as Label;
            if (nameLabel != null)
            {
                nameLabel.ForeColor = Color.LightSalmon;
            }
        }

        void NameLabelLeave(object sender, EventArgs e)
        {
            Label nameLabel = sender as Label;
            if (nameLabel != null)
            {
                nameLabel.ForeColor = Color.Black;
            }
        }

        public void SetButtons()
        {
            if (IsLoggedIn)
            {
                registerButton.Visible = false;
                loginButton.Text = "Sign out";
                loggedInLabel.Visible = true;
                loggedInLabel.Text = "Logged in as " + User.userName;
                cartButton.Visible = true;
                if (User.accessLevel == "admin")
                    adminButton.Visible = true;
            }
            else
            {
                registerButton.Visible = true;
                loginButton.Text = "Login";
                loggedInLabel.Visible = false;
                cartButton.Visible = false;
                adminButton.Visible = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                User = null;
                SetButtons();
            }
            else
            {
                UserLoginForm ulf = new UserLoginForm();
                ulf.Show();
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            UserRegisterForm urf = new UserRegisterForm();
            urf.Show();
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodType = productTypeComboBox.Text;
            if (prodType.Equals("SONG") || prodType.Equals("SAMPLE PACK"))
                genreCheckedListBox.Enabled = true;
            else
                genreCheckedListBox.Enabled = false;
            LoadProducts(1);
        }

        private void genreCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => {
                genres.Clear();
                if (genreCheckedListBox.CheckedItems.Count != 0)
                {
                    for (int x = 0; x <= genreCheckedListBox.CheckedItems.Count - 1; x++)
                    {
                        genres.Add(genreCheckedListBox.CheckedItems[x].ToString());
                    }

                }
                LoadProducts(1);
            }));
        }

        private void priceRangeButton_Click(object sender, EventArgs e)
        {      
            bool isFromPriceDouble = double.TryParse(priceRangeFromTB.Text, out fromPrice);
            
            bool isToPriceDouble = double.TryParse(priceRangeToTB.Text, out toPrice);
            if (String.IsNullOrWhiteSpace(priceRangeFromTB.Text) || !isFromPriceDouble || fromPrice < 0 || String.IsNullOrWhiteSpace(priceRangeToTB.Text) || !isToPriceDouble || toPrice < 0)
            {
                MessageBox.Show("You must enter valid positive numbers!");
                return;
            }

            if (!(fromPrice < toPrice))
            {
                MessageBox.Show("FROM price must be smaller than TO price!");
                return;
            }

            LoadProducts(1);
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            CartForm cf = new CartForm();
            cf.Show();
        }

        
        private void leftArrowPic_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                UpdatePageTextBox();
                LoadProducts(page);
            }
        }

        private void rightArrowPic_Click(object sender, EventArgs e)
        {
            if (page < pageCount)
            {
                page++;
                UpdatePageTextBox();
                LoadProducts(page);
            }
        }

        private void UpdatePageTextBox()
        {
            pageTextBox.Text = "" + page;
        }

       
    }
}
