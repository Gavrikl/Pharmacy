using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pharmacy
{
    class DrugsController
    {
        string connectionString = new SqlConnectionString().GetConnectionString;
        public List<string[]> GetData() // Получение полной информации из база данных для залития в DataGrid
        {
            List<string[]> data = new List<string[]>();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = "SELECT * FROM Drugs";
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки данных\n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public bool AddData(string name, string releaseForm, string dosage, string manufacture, DateTime date)//возращает false неудачное добавление true - удачное
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"INSERT INTO " +
                    $"Drugs(Name, Release_Form, Dosage, Manufacture, Produce_Date) " +
                    $"VALUES " +
                    $"('{name}', '{releaseForm}', '{dosage}', '{manufacture}', '{date.ToString()}')";
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка добавления\n" + ex);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public bool ChangeData(int id, string name, string releaseForm, string dosage, string manufacture, DateTime date)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"UPDATE Drugs SET " +
                    $"Name = '{name}', " +
                    $"Release_Form = '{releaseForm}', " +
                    $"Dosage = '{dosage}', " +
                    $"Manufacture = '{manufacture}'," +
                    $"Produce_Date = '{date.ToString()}'" +
                    $" WHERE ID = {id}";
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка изменения\n" + ex);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

        public bool DeleteData(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"DELETE FROM Drugs WHERE ID = {id}";
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка удаления\n" + ex);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
