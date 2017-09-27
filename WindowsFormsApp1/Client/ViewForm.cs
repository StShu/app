﻿using System;
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
    public partial class ViewForm : TemplateForm
    {
        public ViewForm()
        {
            InitializeComponent();
            setTextForm("Список заказов");
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            DataAccessLayer view = new DataAccessLayer();
            dataGridView1.DataSource = view.clientView(); 
        }
    }
}
