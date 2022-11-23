namespace pharmacy
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.drugButton = new System.Windows.Forms.Button();
            this.pharmacyButton = new System.Windows.Forms.Button();
            this.aviabilityButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drugButton
            // 
            this.drugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.drugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drugButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drugButton.ForeColor = System.Drawing.Color.Black;
            this.drugButton.Location = new System.Drawing.Point(16, 73);
            this.drugButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.drugButton.Name = "drugButton";
            this.drugButton.Size = new System.Drawing.Size(295, 37);
            this.drugButton.TabIndex = 32;
            this.drugButton.Text = "Лекарства";
            this.drugButton.UseVisualStyleBackColor = false;
            this.drugButton.Click += new System.EventHandler(this.drugButton_Click);
            // 
            // pharmacyButton
            // 
            this.pharmacyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.pharmacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pharmacyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pharmacyButton.ForeColor = System.Drawing.Color.Black;
            this.pharmacyButton.Location = new System.Drawing.Point(16, 18);
            this.pharmacyButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.pharmacyButton.Name = "pharmacyButton";
            this.pharmacyButton.Size = new System.Drawing.Size(295, 37);
            this.pharmacyButton.TabIndex = 31;
            this.pharmacyButton.Text = "Аптеки";
            this.pharmacyButton.UseVisualStyleBackColor = false;
            this.pharmacyButton.Click += new System.EventHandler(this.pharmacyButton_Click);
            // 
            // aviabilityButton
            // 
            this.aviabilityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.aviabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aviabilityButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aviabilityButton.ForeColor = System.Drawing.Color.Black;
            this.aviabilityButton.Location = new System.Drawing.Point(16, 128);
            this.aviabilityButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.aviabilityButton.Name = "aviabilityButton";
            this.aviabilityButton.Size = new System.Drawing.Size(295, 37);
            this.aviabilityButton.TabIndex = 33;
            this.aviabilityButton.Text = "Наличие";
            this.aviabilityButton.UseVisualStyleBackColor = false;
            this.aviabilityButton.Click += new System.EventHandler(this.aviabilityButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(338, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aviabilityButton);
            this.Controls.Add(this.drugButton);
            this.Controls.Add(this.pharmacyButton);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drugButton;
        private System.Windows.Forms.Button pharmacyButton;
        private System.Windows.Forms.Button aviabilityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

