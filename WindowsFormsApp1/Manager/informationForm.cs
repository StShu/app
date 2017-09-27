using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Manager
{
    public partial class informationForm : TemplateForm
    {
        public informationForm(DataTable informationCloth, DataTable informationFiting, string name)
        {
            InitializeComponent();
            viewInformation(informationCloth, informationFiting);
            lblName.Text = name;
            setTextForm("Информация об изделии");
        }

        private void viewInformation(DataTable informationCloth, DataTable informationFiting) {
            dgvCloth.DataSource = informationCloth;
        }
    }
}
