using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Storekeeper
{
    public partial class ObtainingMaterials : TemplateForm
    {


        public ObtainingMaterials()
        {
            InitializeComponent();
            setTextForm("Поступление материалов");
        }

        private void ObtainingMaterials_Load(object sender, EventArgs e)
        {
            tabCloth.Enabled = false;
            tabFittings.Enabled = false;
        }

        string temp;
        string[] data;

        public void reset() {
            txtColor.Text = txtComposit.Text = txtHeight.Text = txtHeightF.Text = txtImg.Text = txtImgF.Text = txtName.Text = txtNameF.Text = txtPicture.Text = txtPrice.Text = txtPriceF.Text = txtQuntity.Text = txtSearch.Text = txtTypeF.Text = txtWidth.Text = txtWidthF.Text = "";
            tabCloth.Enabled = false;
            tabFittings.Enabled = false;
            MessageBox.Show("Данные были добавлены", "Информация о добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabCloth.Enabled = true;
            tabFittings.Enabled = true;
            DataAccessLayer search = new DataAccessLayer();
            if (tabControl1.SelectedIndex == 0)
            {
                data = search.searchMaterial("cloth", txtSearch.Text);
                if (data[0] == null)
                    MessageBox.Show("Информация о ткани не найдена!", "Ошибка поиска");
                else
                {
                    txtName.Text = data[2];
                    txtColor.Text = data[3];
                    txtPicture.Text = data[4];
                    txtImg.Text = data[5];
                    txtComposit.Text = data[6];
                    txtWidth.Text = data[7];
                    txtHeight.Text = data[8];
                    txtPrice.Text = data[9];
                }
            }
            else
            {
                data = search.searchMaterial("fittings", txtSearch.Text);
                txtNameF.Text = data[2];
                txtTypeF.Text = data[3];
                txtWidthF.Text = data[4];
                txtHeightF.Text = data[5];
                txtImgF.Text = data[7];
                txtPriceF.Text = data[8];
            }
        }

        private void btnSaveF_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DataAccessLayer upload = new DataAccessLayer();
            if (data[1] == null)
            {
                data[1] = txtSearch.Text;
                data[2] = txtName.Text;
                data[3] = txtColor.Text;
                data[4] = txtPicture.Text;
                data[5] = txtImg.Text;
                data[6] = txtComposit.Text;
                data[7] = txtWidth.Text;
                data[8] = txtHeight.Text;
                data[9] = txtPrice.Text;
                upload.setCloth(data, txtPrice.Text);
                upload.setStorage(data,txtQuntity.Text);
            }
            else
            {
                if (data[9] == txtPrice.Text)
                {
                    upload.updateCloth(txtHeight.Text, txtQuntity.Text, txtSearch.Text);
                }
                else
                {
                    data[9] = txtPrice.Text;
                    upload.setCloth(data, txtPrice.Text);
                    upload.updateCloth(txtHeight.Text, txtQuntity.Text, txtSearch.Text);
                }
            }
            reset();
        }
    }
}
