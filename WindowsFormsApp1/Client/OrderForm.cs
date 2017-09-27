using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Client
{
    public partial class OrderForm : TemplateForm
    {
        public OrderForm()
        {
            InitializeComponent();
            setTextForm("Оформление заказа");
        }
        int endSum=0;
        int sum = 0;
        public void sumGrid() {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Стоимость"].Value);
                txtSum.Text = String.Format("ИТОГО: {0}", Convert.ToInt32(sum));
                endSum = sum;
            }
            sum = 0;
        }

        private void editOrder_Click(object sender, EventArgs e)
        {
            DataAccessLayer ordering = new DataAccessLayer();
            ordering.ordering(cbProduct.Text, Convert.ToInt16(txtQuantity.Text), Convert.ToInt32(cbProduct.SelectedValue));
            dataGridView1.DataSource = ordering.orderingForClient();
            sumGrid();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.information_systemDataSet.product);
            DataAccessLayer ordering = new DataAccessLayer();
            dataGridView1.DataSource = ordering.orderingForClient();
            dataGridView1.Columns["idProduct"].Visible = false;
            sumGrid();
        }
        string[] data = new string[5];
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataAccessLayer ordering = new DataAccessLayer();
            ordering.creatOrder(endSum);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    data[j]=Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                }
                ordering.saveOrder(data,endSum);
            }
            MessageBox.Show("Ваш заказ принят","Информация о заказе",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = ordering.orderingForClient();
            txtSum.Text = "ИТОГО: 0";
        }
    }
}
