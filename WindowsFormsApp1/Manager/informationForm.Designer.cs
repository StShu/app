namespace WindowsFormsApp1.Manager
{
    partial class informationForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCloth = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvFiting = new System.Windows.Forms.DataGridView();
            this.lblCloth = new System.Windows.Forms.Label();
            this.lblFiting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFiting);
            this.panel3.Controls.Add(this.lblCloth);
            this.panel3.Controls.Add(this.dgvFiting);
            this.panel3.Controls.Add(this.dgvCloth);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(12, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 558);
            this.panel3.TabIndex = 2;
            // 
            // dgvCloth
            // 
            this.dgvCloth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCloth.Location = new System.Drawing.Point(3, 104);
            this.dgvCloth.Name = "dgvCloth";
            this.dgvCloth.RowTemplate.Height = 24;
            this.dgvCloth.Size = new System.Drawing.Size(487, 436);
            this.dgvCloth.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(815, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(191, 49);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(383, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название изделия";
            // 
            // dgvFiting
            // 
            this.dgvFiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiting.Location = new System.Drawing.Point(515, 104);
            this.dgvFiting.Name = "dgvFiting";
            this.dgvFiting.RowTemplate.Height = 24;
            this.dgvFiting.Size = new System.Drawing.Size(487, 436);
            this.dgvFiting.TabIndex = 3;
            // 
            // lblCloth
            // 
            this.lblCloth.AutoSize = true;
            this.lblCloth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloth.Location = new System.Drawing.Point(3, 73);
            this.lblCloth.Name = "lblCloth";
            this.lblCloth.Size = new System.Drawing.Size(209, 28);
            this.lblCloth.TabIndex = 4;
            this.lblCloth.Text = "Информация о ткани";
            // 
            // lblFiting
            // 
            this.lblFiting.AutoSize = true;
            this.lblFiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFiting.Location = new System.Drawing.Point(510, 73);
            this.lblFiting.Name = "lblFiting";
            this.lblFiting.Size = new System.Drawing.Size(257, 28);
            this.lblFiting.TabIndex = 5;
            this.lblFiting.Text = "Информация о фурнитуре";
            // 
            // informationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 704);
            this.Controls.Add(this.panel3);
            this.Name = "informationForm";
            this.Text = "informationForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCloth;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFiting;
        private System.Windows.Forms.Label lblCloth;
        private System.Windows.Forms.DataGridView dgvFiting;
    }
}