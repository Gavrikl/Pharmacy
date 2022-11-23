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
    public partial class DrugsForm : Form
    {
        public DrugsForm()
        {
            InitializeComponent();
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            DrugsController drugsController = new DrugsController();
            foreach (string[] s in drugsController.GetData())
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
                drugNameTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                releaseBox1.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                dosageTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                produceTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                dateTextBox.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

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
                drugNameTextBox.Text = "Название";
                releaseBox1.Text = "Форма выпуска";
                dosageTextBox.Text = "Дозировка";
                produceTextBox.Text = "Производитель";
                dateTextBox.Text = "";
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
                deleteButton.Text = $"Удалить";
                changeButton.Text = $"Изменить";
            }
        }

        private void DrugsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void drugNameTextBox_Enter(object sender, EventArgs e)
        {
            if (drugNameTextBox.Text == "Название")
                drugNameTextBox.Text = "";
        }

        private void releaseBox1_Enter(object sender, EventArgs e)
        {
            if (releaseBox1.Text == "Форма выпуска")
                releaseBox1.Text = "Таблетки";

        }

        private void dosageTextBox_Enter(object sender, EventArgs e)
        {
            if (dosageTextBox.Text == "Дозировка")
                dosageTextBox.Text = "";
        }

        private void produceTextBox_Enter(object sender, EventArgs e)
        {
            if (produceTextBox.Text == "Производитель")
                produceTextBox.Text = "";
        }

        private void addPharmacyButton_Click(object sender, EventArgs e)
        {
            DrugsController drugsController = new DrugsController();
            if (drugNameTextBox.Text.Length > 3)
            {
                if (releaseBox1.Text != "Форма выпуска" && releaseBox1.Text.Length > 0)
                {
                    if (dosageTextBox.Text.Length > 3)
                    {
                        if (produceTextBox.Text.Length > 6 && dateTextBox.MaskCompleted)
                        {
                            drugsController.AddData(
                                drugNameTextBox.Text,
                                releaseBox1.Text,
                                dosageTextBox.Text,
                                produceTextBox.Text,
                                Convert.ToDateTime(dateTextBox.Text)
                                );
                            UpdateTable();
                        }

                        else
                        {
                            MessageBox.Show("Название производителя должно быть более 6 букв и должна быть заполнена дата выпуска");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Строка дозировки должна содержать более 3 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Форма выпуска должна быть выбрана");
                }
            }
            else
            {
                MessageBox.Show("Название лекарства должно содержать более 3 символов");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            DrugsController drugsController = new DrugsController();
            if (drugNameTextBox.Text.Length > 3)
            {
                if (releaseBox1.Text != "Форма выпуска" && releaseBox1.Text.Length > 0)
                {
                    if (dosageTextBox.Text.Length > 3)
                    {
                        if (produceTextBox.Text.Length > 6 && dateTextBox.MaskCompleted)
                        {
                            drugsController.ChangeData(
                                idF,
                                drugNameTextBox.Text,
                                releaseBox1.Text,
                                dosageTextBox.Text,
                                produceTextBox.Text,
                                Convert.ToDateTime(dateTextBox.Text)
                                );
                            UpdateTable();
                        }

                        else
                        {
                            MessageBox.Show("Название производителя должно быть более 6 букв и должна быть заполнена дата выпуска");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Строка дозировки должна содержать более 3 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Форма выпуска должна быть выбрана");
                }
            }
            else
            {
                MessageBox.Show("Название лекарства должно содержать более 3 символов");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DrugsController drugsController = new DrugsController();
            drugsController.DeleteData(idF);
            UpdateTable();
        }

        private void drugNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (changedFlag == false)
            {
                changedFlag = true;
                addPharmacyButton.Enabled = true;
                changeButton.Enabled = true;
                deleteButton.Enabled = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if(e.Button == MouseButtons.Right)
                {
                    new drugAviForm(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)).Show();
                }
            }
        }
    }
}
