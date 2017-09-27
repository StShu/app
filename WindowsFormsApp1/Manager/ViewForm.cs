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
    public partial class ViewForm : TemplateForm
    {
        public ViewForm()
        {
            InitializeComponent();
            setTextForm("Просмотр изделий");
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            this.product1TableAdapter.Fill(this.information_systemDataSet.product1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "View") {
                DataAccessLayer view = new DataAccessLayer();
                Form form = new informationForm(view.clothView(Convert.ToString(dataGridView1[0, e.RowIndex].Value)), view.fitingView(Convert.ToString(dataGridView1[0, e.RowIndex].Value)), Convert.ToString(dataGridView1[1, e.RowIndex].Value));
                form.Show();
                pushForm(this);
                this.Hide();
            }
        }
    }
}
