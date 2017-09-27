using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        DataAccessLayer authorization = new DataAccessLayer();

        private void txtLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtLogin.Text == "Введите логин")
                txtLogin.Text = String.Empty;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == String.Empty)
                txtLogin.Text = "Введите логин";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty) {
                txtPassword.Text = "Введите пароль";
                txtPassword.UseSystemPasswordChar = false;             
            }
        }
        
        private void btnIn_Click(object sender, EventArgs e)
        {
            DataAccessLayer auth = new DataAccessLayer();
            string role;
            if (txtLogin.Text.IndexOf("'") == -1 && txtLogin.Text.IndexOf("\"") == -1 && txtPassword.Text.IndexOf("'") == -1 && txtPassword.Text.IndexOf("\"") == -1)
            {
                role = auth.authorization(txtLogin.Text, txtPassword.Text);
                if (role == String.Empty)
                    MessageBox.Show("Введён не правильный логин или пароль!", "Ошибка входа");

                else
                {
                    switch (role.Substring(0, role.IndexOf(" ")))
                    {
                        case "client": Form clientForm = new ClientForm(); clientForm.Show(); this.Hide(); break;
                        case "manager": Form managerForm = new ManagerForm(); managerForm.Show(); this.Hide(); break;
                        case "storekeeper": Form storekeeperForm = new StorekeeperForm(); storekeeperForm.Show(); this.Hide(); break;
                        case "director": Form directorForm = new DirectorForm(); directorForm.Show(); this.Hide(); break;
                    }
                }
            }
            else
                MessageBox.Show("Введён некорьектный логин или пароль!", "Ошибка ввода данных");            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Введите пароль")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = String.Empty;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIn_Click(sender, e);
        }
    }
}
