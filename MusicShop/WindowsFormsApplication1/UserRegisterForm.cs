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
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void regiseterButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;

            List<user> users = MusicShopBL.GetUsers();
            bool isMatch = false;
            foreach (user user in users)
            {
                if (user.userName == username)
                {
                    isMatch = true;
                }
            }

            if (isMatch)
            {
                MessageBox.Show("Username teken! Please choose another one!");
            }
            else
            {
                string password = passwordTextBox.Text;
                DateTime dob = dateTimePicker.Value;
                string email = emailTextBox.Text;

                user newUser = null;
                if (MusicShopBL.RegisterNewUser(username, password, dob, email, ref newUser) == false)
                {
                    MessageBox.Show("Register unsuccessufl!");
                    return;
                }
 
                MessageBox.Show("Register successufl! Welcome " + username);
                MusicShopPage.IsLoggedIn = true;
                MusicShopPage.User = newUser;
                MusicShopPage.msp.SetButtons();
                if (this.Tag != null)
                    (this.Tag as ProductForm).MyLoad();
                this.Close();

            }
        }
    }
}
