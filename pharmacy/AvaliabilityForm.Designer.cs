namespace pharmacy
{
    partial class AvaliabilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvaliabilityForm));
            this.produceTextBox = new System.Windows.Forms.TextBox();
            this.pharmacyBox = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.addPharmacyButton = new System.Windows.Forms.Button();
            this.drugBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // produceTextBox
            // 
            this.produceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.produceTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.produceTextBox.ForeColor = System.Drawing.Color.Black;
            this.produceTextBox.Location = new System.Drawing.Point(22, 108);
            this.produceTextBox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.produceTextBox.MaxLength = 320;
            this.produceTextBox.Name = "produceTextBox";
            this.produceTextBox.Size = new System.Drawing.Size(532, 27);
            this.produceTextBox.TabIndex = 31;
            this.produceTextBox.Text = "Цена";
            this.produceTextBox.TextChanged += new System.EventHandler(this.pharmacyBox_TextChanged);
            this.produceTextBox.Enter += new System.EventHandler(this.produceTextBox_Enter);
            this.produceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.produceTextBox_KeyPress);
            // 
            // pharmacyBox
            // 
            this.pharmacyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.pharmacyBox.FormattingEnabled = true;
            this.pharmacyBox.Location = new System.Drawing.Point(22, 22);
            this.pharmacyBox.Margin = new System.Windows.Forms.Padding(4);
            this.pharmacyBox.Name = "pharmacyBox";
            this.pharmacyBox.Size = new System.Drawing.Size(531, 27);
            this.pharmacyBox.TabIndex = 30;
            this.pharmacyBox.Text = "Идентификатор аптеки";
            this.pharmacyBox.TextChanged += new System.EventHandler(this.pharmacyBox_TextChanged);
            this.pharmacyBox.Enter += new System.EventHandler(this.pharmacyBox_Enter);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.changeButton.Enabled = false;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(258, 187);
            this.changeButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(295, 37);
            this.changeButton.TabIndex = 29;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(258, 232);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(295, 37);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NamePharm,
            this.address,
            this.email,
            this.Phone});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dataGridView1.Location = new System.Drawing.Point(565, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 247);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Код наличия";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NamePharm
            // 
            this.NamePharm.HeaderText = "Код аптеки";
            this.NamePharm.Name = "NamePharm";
            this.NamePharm.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Код лекарства";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Количество";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Цена";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dosageTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dosageTextBox.ForeColor = System.Drawing.Color.Black;
            this.dosageTextBox.Location = new System.Drawing.Point(22, 141);
            this.dosageTextBox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.dosageTextBox.MaxLength = 320;
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(532, 27);
            this.dosageTextBox.TabIndex = 26;
            this.dosageTextBox.Text = "Количество";
            this.dosageTextBox.TextChanged += new System.EventHandler(this.pharmacyBox_TextChanged);
            this.dosageTextBox.Enter += new System.EventHandler(this.dosageTextBox_Enter);
            this.dosageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dosageTextBox_KeyPress);
            // 
            // addPharmacyButton
            // 
            this.addPharmacyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.addPharmacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPharmacyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPharmacyButton.ForeColor = System.Drawing.Color.Black;
            this.addPharmacyButton.Location = new System.Drawing.Point(22, 187);
            this.addPharmacyButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.addPharmacyButton.Name = "addPharmacyButton";
            this.addPharmacyButton.Size = new System.Drawing.Size(225, 82);
            this.addPharmacyButton.TabIndex = 24;
            this.addPharmacyButton.Text = "Добавить";
            this.addPharmacyButton.UseVisualStyleBackColor = false;
            this.addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
            // 
            // drugBox
            // 
            this.drugBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.drugBox.FormattingEnabled = true;
            this.drugBox.Location = new System.Drawing.Point(22, 57);
            this.drugBox.Margin = new System.Windows.Forms.Padding(4);
            this.drugBox.Name = "drugBox";
            this.drugBox.Size = new System.Drawing.Size(532, 27);
            this.drugBox.TabIndex = 32;
            this.drugBox.Text = "Идентификатор лекарства";
            this.drugBox.TextChanged += new System.EventHandler(this.pharmacyBox_TextChanged);
            this.drugBox.Enter += new System.EventHandler(this.drugBox_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(22, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 10);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.panel2.Location = new System.Drawing.Point(284, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 10);
            this.panel2.TabIndex = 34;
            // 
            // AvaliabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1288, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drugBox);
            this.Controls.Add(this.produceTextBox);
            this.Controls.Add(this.pharmacyBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.addPharmacyButton);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AvaliabilityForm";
            this.Text = "Настройка доступности";
            this.Load += new System.EventHandler(this.AvaliabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox produceTextBox;
        private System.Windows.Forms.ComboBox pharmacyBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.Button addPharmacyButton;
        private System.Windows.Forms.ComboBox drugBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}