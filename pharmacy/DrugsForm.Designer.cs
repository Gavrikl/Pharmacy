namespace pharmacy
{
    partial class DrugsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugsForm));
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.addPharmacyButton = new System.Windows.Forms.Button();
            this.releaseBox1 = new System.Windows.Forms.ComboBox();
            this.produceTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePharm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.changeButton.Enabled = false;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(193, 194);
            this.changeButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(221, 38);
            this.changeButton.TabIndex = 20;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(193, 241);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(221, 38);
            this.deleteButton.TabIndex = 19;
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
            this.Phone,
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dataGridView1.Location = new System.Drawing.Point(426, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(908, 268);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dosageTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dosageTextBox.ForeColor = System.Drawing.Color.Black;
            this.dosageTextBox.Location = new System.Drawing.Point(14, 83);
            this.dosageTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dosageTextBox.MaxLength = 320;
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(400, 27);
            this.dosageTextBox.TabIndex = 16;
            this.dosageTextBox.Text = "Дозировка";
            this.dosageTextBox.TextChanged += new System.EventHandler(this.drugNameTextBox_TextChanged);
            this.dosageTextBox.Enter += new System.EventHandler(this.dosageTextBox_Enter);
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.drugNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drugNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.drugNameTextBox.Location = new System.Drawing.Point(14, 11);
            this.drugNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drugNameTextBox.MaxLength = 50;
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.Size = new System.Drawing.Size(400, 27);
            this.drugNameTextBox.TabIndex = 14;
            this.drugNameTextBox.Text = "Название";
            this.drugNameTextBox.TextChanged += new System.EventHandler(this.drugNameTextBox_TextChanged);
            this.drugNameTextBox.Enter += new System.EventHandler(this.drugNameTextBox_Enter);
            // 
            // addPharmacyButton
            // 
            this.addPharmacyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.addPharmacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPharmacyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPharmacyButton.ForeColor = System.Drawing.Color.Black;
            this.addPharmacyButton.Location = new System.Drawing.Point(15, 194);
            this.addPharmacyButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addPharmacyButton.Name = "addPharmacyButton";
            this.addPharmacyButton.Size = new System.Drawing.Size(169, 85);
            this.addPharmacyButton.TabIndex = 13;
            this.addPharmacyButton.Text = "Добавить";
            this.addPharmacyButton.UseVisualStyleBackColor = false;
            this.addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
            // 
            // releaseBox1
            // 
            this.releaseBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.releaseBox1.FormattingEnabled = true;
            this.releaseBox1.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.releaseBox1.Location = new System.Drawing.Point(14, 47);
            this.releaseBox1.Name = "releaseBox1";
            this.releaseBox1.Size = new System.Drawing.Size(400, 27);
            this.releaseBox1.TabIndex = 21;
            this.releaseBox1.Text = "Форма выпуска";
            this.releaseBox1.TextChanged += new System.EventHandler(this.drugNameTextBox_TextChanged);
            this.releaseBox1.Enter += new System.EventHandler(this.releaseBox1_Enter);
            // 
            // produceTextBox
            // 
            this.produceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.produceTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.produceTextBox.ForeColor = System.Drawing.Color.Black;
            this.produceTextBox.Location = new System.Drawing.Point(14, 122);
            this.produceTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.produceTextBox.MaxLength = 320;
            this.produceTextBox.Name = "produceTextBox";
            this.produceTextBox.Size = new System.Drawing.Size(400, 27);
            this.produceTextBox.TabIndex = 22;
            this.produceTextBox.Text = "Производитель";
            this.produceTextBox.TextChanged += new System.EventHandler(this.drugNameTextBox_TextChanged);
            this.produceTextBox.Enter += new System.EventHandler(this.produceTextBox_Enter);
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.dateTextBox.Location = new System.Drawing.Point(14, 158);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(400, 27);
            this.dateTextBox.TabIndex = 23;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            this.dateTextBox.TextChanged += new System.EventHandler(this.drugNameTextBox_TextChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Код лекарства";
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
            this.address.HeaderText = "Форма выпуска";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Дозировка";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Производитель";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата производства";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Щелкните по любому лекарству правой кнопкой мыши, чтобы увидеть список аптек, где" +
    " есть запасы лекарства.";
            // 
            // DrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1349, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.produceTextBox);
            this.Controls.Add(this.releaseBox1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.drugNameTextBox);
            this.Controls.Add(this.addPharmacyButton);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrugsForm";
            this.Text = "Лекарства";
            this.Load += new System.EventHandler(this.DrugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.Button addPharmacyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox releaseBox1;
        private System.Windows.Forms.TextBox produceTextBox;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label label1;
    }
}