namespace pharmacy
{
    partial class CreatePharmacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePharmacyForm));
            this.telephoneBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.pharmacyNameTextBox = new System.Windows.Forms.TextBox();
            this.addPharmacyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // telephoneBox
            // 
            this.telephoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.telephoneBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.telephoneBox.Location = new System.Drawing.Point(16, 162);
            this.telephoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneBox.Mask = "(999) 000-0000";
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(301, 27);
            this.telephoneBox.TabIndex = 9;
            this.telephoneBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.emailTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(16, 114);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 320;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(301, 27);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.Text = "Почта";
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.addressTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.Location = new System.Drawing.Point(16, 66);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.MaxLength = 100;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 27);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Text = "Адрес";
            this.addressTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.addressTextBox.Enter += new System.EventHandler(this.addressTextBox_Enter);
            // 
            // pharmacyNameTextBox
            // 
            this.pharmacyNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.pharmacyNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pharmacyNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.pharmacyNameTextBox.Location = new System.Drawing.Point(16, 18);
            this.pharmacyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pharmacyNameTextBox.MaxLength = 50;
            this.pharmacyNameTextBox.Name = "pharmacyNameTextBox";
            this.pharmacyNameTextBox.Size = new System.Drawing.Size(301, 27);
            this.pharmacyNameTextBox.TabIndex = 6;
            this.pharmacyNameTextBox.Text = "Название";
            this.pharmacyNameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.pharmacyNameTextBox.Enter += new System.EventHandler(this.pharmacyNameTextBox_Enter);
            // 
            // addPharmacyButton
            // 
            this.addPharmacyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.addPharmacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPharmacyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPharmacyButton.ForeColor = System.Drawing.Color.Black;
            this.addPharmacyButton.Location = new System.Drawing.Point(16, 210);
            this.addPharmacyButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPharmacyButton.Name = "addPharmacyButton";
            this.addPharmacyButton.Size = new System.Drawing.Size(127, 74);
            this.addPharmacyButton.TabIndex = 5;
            this.addPharmacyButton.Text = "Добавить";
            this.addPharmacyButton.UseVisualStyleBackColor = false;
            this.addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(325, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 266);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Код аптеки";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NamePharm
            // 
            this.NamePharm.HeaderText = "Название";
            this.NamePharm.Name = "NamePharm";
            this.NamePharm.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Почта";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(151, 251);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(166, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.changeButton.Enabled = false;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(151, 210);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(166, 33);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // CreatePharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1072, 297);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.pharmacyNameTextBox);
            this.Controls.Add(this.addPharmacyButton);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatePharmacyForm";
            this.Text = "Создание новой аптеки";
            this.Load += new System.EventHandler(this.CreatePharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telephoneBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox pharmacyNameTextBox;
        private System.Windows.Forms.Button addPharmacyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}