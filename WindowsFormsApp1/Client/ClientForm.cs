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
    public partial class ClientForm : TemplateForm
    {
        public ClientForm()
        {
            InitializeComponent();
            setTextForm();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form form = new Client.ViewForm();
            form.Show();
            pushForm(this);
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form form = new Client.CreateForm();
            form.Show();
            pushForm(this);
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form form = new Client.OrderForm();
            form.Show();
            pushForm(this);
            this.Hide();
        }
    }
}
