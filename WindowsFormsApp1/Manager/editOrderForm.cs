using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Manager
{
    public partial class editOrderForm : TemplateForm
    {
             public editOrderForm()
        {
            InitializeComponent();
            setTextForm("Изменение статуса заказа");
            DataAccessLayer statusEdit = new DataAccessLayer();
            dataGridView1.DataSource = statusEdit.editOrderStatus();
            
            DataGridViewComboBoxColumn statusBox = new DataGridViewComboBoxColumn();
            statusBox.HeaderText = "Статус заказа";
            statusBox.MaxDropDownItems = 8;
            statusBox.DropDownWidth = 90;
            statusBox.Width = 90;
            statusBox.DataSource = statusTableAdapter.GetData();
            statusBox.ValueMember = "Id";
            statusBox.DisplayMember = "status";
            //statusBox.DefaultCellStyle.NullValue = statusBox.Items[1];
            // statusBox.Items.AddRange("");
            dataGridView1.Columns.Insert(1, statusBox);      
            #region test1
                /* //Добавление столбца - тип ComboBox
                DataGridViewColumn column1 = new DataGridViewColumn();
                DataGridViewCell cell1 = new DataGridViewComboBoxCell();
                column1.HeaderText = "Статус заказа";
                column1.Name = "statusGrid";
                column1.CellTemplate = cell1;
                dataGridView1.Columns.Add(column1);

                //Добавление данных
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewComboBoxCell cell_CB = new DataGridViewComboBoxCell();
                //Вписываем текст в заголовок строки
                row.HeaderCell.Value = "1";
                row.CreateCells(dataGridView1);
                //Создаем массив который будет помещен в ячейку
                cell_CB.Items.AddRange(new string[] { "Первый", "Второй", "Третий", "Четвертый" });
                row.Cells[0] = cell_CB;

                //выбираем строчку по умолчанию - здесь выбрана под номером 2.
                row.Cells[0].Value = (row.Cells[0] as DataGridViewComboBoxCell).Items[2];
                //Вносим в dataGridView
                dataGridView1.Rows.Add(row);
                */
            #endregion
        }
        private void editOrderForm_Load(object sender, EventArgs e)
        {
            this.statusTableAdapter.Fill(this.information_systemDataSet.status);
            dataGridView1.Columns["stage"].Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++) {
                dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[5].Value;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataAccessLayer statusEdit = new DataAccessLayer();
            statusEdit.updateStatus(Convert.ToInt32(dataGridView1[1,e.RowIndex].Value), Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
            MessageBox.Show("Статус заказа обновлен", "Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
