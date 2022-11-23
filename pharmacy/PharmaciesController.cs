using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacy
{
    class PharmaciesController
    {
        string connectionString = new SqlConnectionString().GetConnectionString;
        public List<string[]> GetData() // Получение полной информации из база данных для залития в DataGrid
        {
            List<string[]> data = new List<string[]>();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = "SELECT * FROM Pharmacies";
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

        public bool AddData(string name, string address, string email = "", string telephone = "")//возращает false неудачное добавление true - удачное
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"INSERT INTO Pharmacies(Name, Address, Email, Telephone) VALUES ('{name}', '{address}', '{email}', '{telephone}')";
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
        
        public bool ChangeData(int id,string name, string address, string email , string telephone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string command = $"UPDATE Pharmacies SET Name = '{name}', Address = '{address}', Email = '{email}', Telephone = '{telephone}' WHERE ID = {id}";
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
                string command = $"DELETE FROM Pharmacies WHERE ID = {id}";
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
