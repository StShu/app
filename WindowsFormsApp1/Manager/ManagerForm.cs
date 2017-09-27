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
    public partial class ManagerForm : TemplateForm
    {
        public ManagerForm()
        {
            InitializeComponent();
            setTextForm();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form form = new Manager.ViewForm();
            form.Show();
            pushForm(this);
            this.Hide();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            Form form = new Manager.editOrderForm();
            form.Show();
            pushForm(this);
            this.Hide();
        }
    }
}
