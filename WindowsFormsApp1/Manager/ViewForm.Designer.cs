namespace WindowsFormsApp1.Manager
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.information_systemDataSet = new WindowsFormsApp1.information_systemDataSet();
            this.product1TableAdapter = new WindowsFormsApp1.information_systemDataSetTableAdapters.product1TableAdapter();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дополниельнаяИнформацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.дополниельнаяИнформацияDataGridViewTextBoxColumn,
            this.View});
            this.dataGridView1.DataSource = this.product1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 558);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // product1BindingSource
            // 
            this.product1BindingSource.DataMember = "product1";
            this.product1BindingSource.DataSource = this.information_systemDataSet;
            // 
            // information_systemDataSet
            // 
            this.information_systemDataSet.DataSetName = "information_systemDataSet";
            this.information_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product1TableAdapter
            // 
            this.product1TableAdapter.ClearBeforeFill = true;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            // 
            // дополниельнаяИнформацияDataGridViewTextBoxColumn
            // 
            this.дополниельнаяИнформацияDataGridViewTextBoxColumn.DataPropertyName = "Дополниельная информация";
            this.дополниельнаяИнформацияDataGridViewTextBoxColumn.HeaderText = "Дополниельная информация";
            this.дополниельнаяИнформацияDataGridViewTextBoxColumn.Name = "дополниельнаяИнформацияDataGridViewTextBoxColumn";
            // 
            // View
            // 
            this.View.DataPropertyName = "View";
            this.View.HeaderText = "Просмотр";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 704);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_systemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private information_systemDataSet information_systemDataSet;
        private System.Windows.Forms.BindingSource product1BindingSource;
        private information_systemDataSetTableAdapters.product1TableAdapter product1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дополниельнаяИнформацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}