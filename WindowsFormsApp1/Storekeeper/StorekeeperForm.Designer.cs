namespace WindowsFormsApp1
{
    partial class StorekeeperForm
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
            this.btn_obtaining_materials = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_obtaining_materials
            // 
            this.btn_obtaining_materials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_obtaining_materials.Location = new System.Drawing.Point(40, 141);
            this.btn_obtaining_materials.Name = "btn_obtaining_materials";
            this.btn_obtaining_materials.Size = new System.Drawing.Size(236, 55);
            this.btn_obtaining_materials.TabIndex = 2;
            this.btn_obtaining_materials.Text = "Поступление материалов";
            this.btn_obtaining_materials.UseVisualStyleBackColor = true;
            this.btn_obtaining_materials.Click += new System.EventHandler(this.btn_obtaining_materials_Click);
            // 
            // StorekeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 572);
            this.Controls.Add(this.btn_obtaining_materials);
            this.Name = "StorekeeperForm";
            this.Text = "StorekeeperForm";
            this.Load += new System.EventHandler(this.StorekeeperForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btn_obtaining_materials, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_obtaining_materials;
    }
}