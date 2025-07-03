using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Arian_project.backend.Database;
using ghest.Backend.Logs;
namespace Arian_project.backend.database
{
    internal class clients_database
    {
        private log logger = new log();
        private SQLiteConnection clients_database_connection()
        {
            var database = Database_data.database;
            var database_connection = new SQLiteConnection(database);
            return database_connection;
        }


        public List<Client> clients_list(string sql_query="")
        {
            string logger_message_type = "clients database";
            if(sql_query == "")
            {
                sql_query = "SELECT * FROM clients";
            }
            var clients = new List<Client>();
            try
            {
                using (var connection = clients_database_connection())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection))
                    {
                        var reader = command.ExecuteReader();
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                clients.Add(new Client(reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6),
                                    reader.GetString(7)));
                            }
                        }
                    }

                    connection.Close();
                }

                
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => "+sql_query, logger_message_type);
                logger.record_log(ex.ToString(),logger_message_type);
            }
            return clients;

        }

        public bool insert_client_to_database(Client client) {
            string logger_message_type = "insert_client_to_database";
            bool result = false;
            if(client.id != 0)
            {
                try
                {
                    string sql_query = $"INSERT INTO clients (id,user_name,phone_number,home_number,company,email,client_type,client_group)VALUES('{client.id}','{client.user_name}','{client.phone_number}','{client.home_number}','{client.company}','{client.email}','{client.client_type}','{client.client_group}')";

                    var connection = clients_database_connection();
                    connection.Open();
                    var command = new SQLiteCommand(sql_query,connection);
                    int res = command.ExecuteNonQuery();
                    if (res > 0) { 
                        result = true;
                    }
                    connection.Close() ;
                }
                catch (Exception ex) {
                    logger.record_log(ex.ToString(),logger_message_type);
                }
                return result;
            }
            else
            {

                return false;
            }

        }

    }
}
