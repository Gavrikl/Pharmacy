using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacy
{
    class Avaliabilities
    {

        string connectionString = new SqlConnectionString().GetConnectionString;
        public List<string[]> GetData() // Получение полной информации из база данных для залития в DataGrid
        {
            List<string[]> data = new List<string[]>();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = "SELECT * FROM Availability";
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

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
        public string ConvertToDot(double value) // Изменение , в .
        {
            string converter = value.ToString();
            converter = converter.Replace(",", ".");
            return converter;
        }

        public bool AddData(int idPharmacy, int idDrug, int count, double money)//возращает false неудачное добавление true - удачное
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"INSERT INTO Availability(Id_Pharmacy, Id_Drug, Count, Price) VALUES ({idPharmacy}, {idDrug}, {count}, {ConvertToDot(money)})";
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

        public bool ChangeData(int id, int idPharmacy, int idDrug, int count, double money)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"UPDATE Availability SET Id_Pharmacy = {idPharmacy}, Id_Drug = {idDrug}, Count = {count}, Price = {ConvertToDot(money)} WHERE ID = {id}";
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
                string command = $"DELETE FROM Availability WHERE ID = {id}";
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

        public double AverageData(int drugId)
        {
            double average = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"SELECT AVG(Price) FROM Availability WHERE Id_Drug = {drugId}";
                SqlCommand cmd = new SqlCommand(command, connection);
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    average = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
                return 0;
            }
            finally
            {
                connection.Close();
            }
            return average;
        }
        public List<string[]> GetDataByDrugId(int drugId) // Получение информации по DrugID
        {
            List<string[]> data = new List<string[]>();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"SELECT * FROM Availability WHERE Id_Drug = {drugId}";
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

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

    }

}
