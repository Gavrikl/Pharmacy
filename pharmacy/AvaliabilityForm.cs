using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class AvaliabilityForm : Form
    {
        public AvaliabilityForm()
        {
            InitializeComponent();
        }

        private void AvaliabilityForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            PharmaciesController pharmacyController = new PharmaciesController();
            foreach (string[] s in pharmacyController.GetData())
            {
                pharmacyBox.Items.Add($"{s[0]}|{s[1]}");
            }
            DrugsController drugController = new DrugsController();
            foreach (string[] s in drugController.GetData())
            {
                drugBox.Items.Add($"{s[0]}|{s[1]}");
            }
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            Avaliabilities avController = new Avaliabilities();
            foreach (string[] s in avController.GetData())
            {
                dataGridView1.Rows.Add(s);
            }

        }
        private void drugNameTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void pharmacyBox_Enter(object sender, EventArgs e)
        {
            if (pharmacyBox.Text == "Идентификатор аптеки")
                pharmacyBox.Text = pharmacyBox.Items[0].ToString();
        }

        private void drugBox_Enter(object sender, EventArgs e)
        {
            if (drugBox.Text == "Идентификатор лекарства")
                drugBox.Text = drugBox.Items[0].ToString();
        }

        private void produceTextBox_Enter(object sender, EventArgs e)
        {
            if (produceTextBox.Text == "Цена")
                produceTextBox.Text = "";
        }

        private void dosageTextBox_Enter(object sender, EventArgs e)
        {
            if (dosageTextBox.Text == "Количество")
                dosageTextBox.Text = "";
        }

        private void addPharmacyButton_Click(object sender, EventArgs e)
        {
            Avaliabilities avaliabilitiesController = new Avaliabilities();
            if (pharmacyBox.Text != "Идентификатор аптеки" && pharmacyBox.Text.Contains("|"))
            {
                if (drugBox.Text != "Идентификатор лекарства" && drugBox.Text.Contains("|"))
                {
                    if (produceTextBox.Text.Length > 0)
                    {
                        if (dosageTextBox.Text.Length > 0)
                        {
                            avaliabilitiesController.AddData(
                                Convert.ToInt32(pharmacyBox.Text.Substring(0, pharmacyBox.Text.IndexOf('|'))),
                                Convert.ToInt32(drugBox.Text.Substring(0, drugBox.Text.IndexOf('|'))),
                                Convert.ToInt32(dosageTextBox.Text),
                                Convert.ToDouble(produceTextBox.Text)
                                );
                            UpdateTable();
                        }

                        else
                        {
                            MessageBox.Show("Количество должно быть больше 0 символов");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Цена должна содержать больше 0 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите идентификатор лекарства");
                }
            }
            else
            {
                MessageBox.Show("Выберите идентификатор аптеки");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Avaliabilities avaliabilitiesController = new Avaliabilities();
            if (pharmacyBox.Text != "Идентификатор аптеки")
            {
                if (drugBox.Text != "Идентификатор лекарства")
                {
                    if (produceTextBox.Text.Length > 0)
                    {
                        if (dosageTextBox.Text.Length > 0)
                        {
                            avaliabilitiesController.ChangeData(
                                idF,
                                Convert.ToInt32(pharmacyBox.Text.Substring(0, pharmacyBox.Text.IndexOf('|'))),
                                Convert.ToInt32(drugBox.Text.Substring(0, drugBox.Text.IndexOf('|'))),
                                Convert.ToInt32(dosageTextBox.Text),
                                Convert.ToDouble(produceTextBox.Text)
                                );
                            UpdateTable();
                        }

                        else
                        {
                            MessageBox.Show("Количество должно быть больше 0 символов");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Цена должна содержать больше 0 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите идентификатор лекарства");
                }
            }
            else
            {
                MessageBox.Show("Выберите идентификатор аптеки");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Avaliabilities avaliabilitiesController = new Avaliabilities();
            avaliabilitiesController.DeleteData(idF);
            UpdateTable();
        }
        bool changedFlag = true;
        int idF = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                idF = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                pharmacyBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "|";

                drugBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "|";

                dosageTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                produceTextBox.Text =
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

                pharmacyBox.Text = "Идентификатор аптеки";
                drugBox.Text = "Идентификатор лекарства";
                produceTextBox.Text = "Цена";
                dosageTextBox.Text = "Количество";
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
                deleteButton.Text = $"Удалить";
                changeButton.Text = $"Изменить";
            }
        }

        private void pharmacyBox_TextChanged(object sender, EventArgs e)
        {
            if (changedFlag == false)
            {
                changedFlag = true;
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = true;
                deleteButton.Enabled = false;
            }
        }

        private void produceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dosageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
