using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class CreatePharmacyForm : Form
    {
        public CreatePharmacyForm()
        {
            InitializeComponent();
        }

        private void CreatePharmacy_Load(object sender, EventArgs e)
        {

            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            PharmaciesController pharmacyController = new PharmaciesController();
            foreach (string[] s in pharmacyController.GetData())
            {
                dataGridView1.Rows.Add(s);
            }

        }
        bool changedFlag = true;
        int idF = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                idF = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                pharmacyNameTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                addressTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                emailTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                telephoneBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                addPharmacyButton.Enabled = false;
                changeButton.Enabled = true;
                deleteButton.Enabled = true;
                changedFlag = false;
                deleteButton.Text = $"Удалить (ID - {idF})";
                changeButton.Text = $"Изменить (ID - {idF})";
            }
            else
            {
                changedFlag = true;
                pharmacyNameTextBox.Text = "Название";
                addressTextBox.Text = "Адрес";
                emailTextBox.Text = "Почта";
                telephoneBox.Text = "";
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
                deleteButton.Text = $"Удалить";
                changeButton.Text = $"Изменить";
            }
        }

        private void pharmacyNameTextBox_Enter(object sender, EventArgs e)
        {
            if (pharmacyNameTextBox.Text == "Название")
                pharmacyNameTextBox.Text = "";
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "Адрес")
                addressTextBox.Text = "";
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Почта")
                emailTextBox.Text = "";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (changedFlag == false)
            {
                changedFlag = true;
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = true;
                deleteButton.Enabled = false;
            }
        }

        private void addPharmacyButton_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); // Регистр для почты
            PharmaciesController pharmacyController = new PharmaciesController();
            if (pharmacyNameTextBox.Text.Length > 3)
            {
                if (addressTextBox.Text.Length > 6)
                {
                    if (reg.IsMatch(emailTextBox.Text) || telephoneBox.MaskCompleted)
                    {
                        pharmacyController.AddData(
                            pharmacyNameTextBox.Text,
                            addressTextBox.Text,
                            emailTextBox.Text,
                            telephoneBox.Text
                            );
                        UpdateTable();
                    }
                    else
                    {
                        MessageBox.Show("Введите телефон аптеки, почту или все вместе\nПример почты apteka1@gmail.com");
                    }
                }
                else
                {
                    MessageBox.Show("Адрес аптеки должен содержать больше 6 символов");
                }
            }
            else
            {
                MessageBox.Show("Название аптеки должно содержать больше 3 символов");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); // Регистр для почты
            PharmaciesController pharmacyController = new PharmaciesController();
            if (pharmacyNameTextBox.Text.Length > 3)
            {
                if (addressTextBox.Text.Length > 6)
                {
                    if (reg.IsMatch(emailTextBox.Text) || telephoneBox.MaskCompleted)
                    {
                        pharmacyController.ChangeData(
                            idF,
                            pharmacyNameTextBox.Text,
                            addressTextBox.Text,
                            emailTextBox.Text,
                            telephoneBox.Text
                            );
                        UpdateTable();
                    }
                    else
                    {
                        MessageBox.Show("Введите телефон аптеки, почту или все вместе\nПример почты apteka1@gmail.com");
                    }
                }
                else
                {
                    MessageBox.Show("Адрес аптеки должен содержать больше 6 символов");
                }
            }
            else
            {
                MessageBox.Show("Название аптеки должно содержать больше 3 символов");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PharmaciesController pharmacyController = new PharmaciesController();
            pharmacyController.DeleteData(idF);
            UpdateTable();
        }
    }
}
