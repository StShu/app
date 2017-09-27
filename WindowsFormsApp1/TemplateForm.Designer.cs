namespace WindowsFormsApp1
{
    partial class TemplateForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.pctBoxLogo);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 108);
            this.panel1.TabIndex = 0;
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Image = global::WindowsFormsApp1.Properties.Resources.logo_01;
            this.pctBoxLogo.Location = new System.Drawing.Point(144, -2);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(744, 110);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBoxLogo.TabIndex = 2;
            this.pctBoxLogo.TabStop = false;
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOut.Location = new System.Drawing.Point(894, -1);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(138, 110);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "ВЫЙТИ";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 108);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "НАЗАД";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 26);
            this.panel2.TabIndex = 1;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система \"ШВЕЯ\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pctBoxLogo;
        protected System.Windows.Forms.Button btnOut;
        protected System.Windows.Forms.Button btnBack;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel panel1;
    }
}

