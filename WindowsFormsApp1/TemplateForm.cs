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
    public partial class TemplateForm : Form
    {

        private static Stack<Form> lastWindows = new Stack<Form>();
        public TemplateForm()
        {
            InitializeComponent();
            
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
            this.Hide();
            lastWindows.Clear();
        }

        public void pushForm(Form Form) {
                lastWindows.Push(Form);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            if (lastWindows.Count >= 1)
            {
                lastWindows.Pop().Show();
                this.Hide();
            }
            else
            {
                Form authForm = new AuthorizationForm();
                authForm.Show();
                this.Hide();
            } 

        }

        public void setTextForm(string arg = "") {
            DataAccessLayer loginRoleDAL = new DataAccessLayer();
            string login = loginRoleDAL.getLogin();
            string role = loginRoleDAL.getRole();
            switch (role.Substring(0, role.IndexOf(" "))) {
                case "client": role = "Клиент"; break;
                case "manager": role = "Менеджер"; break;
                case "storekeeper": role = "Кладовщик"; break;
                case "director": role = "Директор"; break; 
            }
            if(arg == String.Empty)
                this.Text = "Информационная система \"ШВЕЯ\" - " + login + " - " + role;
            else
                this.Text = "Информационная система \"ШВЕЯ\" - " + login + " - " + role + " - " + arg;
        }

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
