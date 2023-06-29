using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystemCSharp
{/*
    public class DBHelper
    {
        #region Singleton
        private static DBHelper instance;

        public static DBHelper GetInstance
        {
            get
            {
                if(instance == null)
                    instance = new DBHelper();
                return instance;
            }
        }

        private DBHelper()
        {

        }
        #endregion

        private MySqlConnection connection;

        public void Select()
        {
            if (GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query);
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
            }
        }

        private bool GetConnection()
        {
            if(connection?.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                try
                {
                    connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void deleteRecord(string name_table,int id)
        {
            using (MySqlCommand command = new MySqlCommand("DeleteRecordByIndex", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@tableName", name_table); //  имя вашей таблицы.
                command.Parameters.AddWithValue("@recordIndex", id); //  (ID) записи, которую вы хотите удалить.

                command.ExecuteNonQuery();
            }
        }

        private void getUser(string name_table, int id)
        {
            using (MySqlCommand command = new MySqlCommand("GetUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@tableName", name_table); // на имя вашей таблицы.
                command.Parameters.AddWithValue("@userId", id); //  ID пользователя.

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Чтение данных пользователя из результата запроса
                        int userId = reader.GetInt32("id");
                        string userName = reader.GetString("name");
                        // Продолжайте чтение остальных данных пользователя из результата запроса

                        // Обработка полученных данных
                    }
                }
            }
        }
    }
*/}
