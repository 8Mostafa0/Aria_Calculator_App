using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ghest.Backend.Logs;
namespace Arian_project.backend
{
    public class clients_database
    {
        private log logger = new log();

        Database_data database = new Database_data();

        public int clients_count()
        {
            int users_count = 0;
            string message_type = "get clients count from clients table";
            string logger_message_type = "clients_count";
            string sql_query = "SELECT COUNT(*) FROM clients";
            users_count = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            return users_count;
        }
        public List<Client> clients_list(string sql_query="")
        {
            string logger_message_type = "clients database";
            logger.record_log("get clients list from clients table", logger_message_type);
            if(sql_query == "")
            {
                sql_query = "SELECT * FROM clients";
            }
            var clients = new List<Client>();
            try
            {
                using (var connection = database.connection_to_db())
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
            string message_type = "insert new client to clients table";
            bool result = false;
            if(client.id != 0)
            {
                string sql_query = $"INSERT INTO clients (id,user_name,phone_number,home_number,company,email,client_type,client_group)VALUES('{client.id}','{client.user_name}','{client.phone_number}','{client.home_number}','{client.company}','{client.email}','{client.client_type}','{client.client_group}')";
                result = database.run_sql_query( sql_query,message_type,logger_message_type);
                return result;
            }
            else
            {
                return false;
            }

        }

        public bool edite_client_in_database(Client user)
        {
            string logger_message_type = "edite_client_in_database";
            string message_type = "edite clients in clients table";
            string sql_query = $"UPDATE clients SET user_name='{user.user_name}',phone_number='{user.phone_number}',home_number='{user.home_number}',company='{user.company}',email='{user.email}',client_type='{user.client_type}',client_group='{user.client_group}' WHERE id='{user.id}'";
            bool result = false;
            database.run_sql_query(sql_query,message_type,logger_message_type);
            return result;
        }

        public bool delete_client_from_database(int id)
        {
            string logger_message_type = "delete_client_from_database";
            string message_type = "delete client from clients table";
            string sql_query = $"DELETE FROM clients WHERE id='{id}'";
            bool result = false;
            database.run_sql_query(sql_query,message_type,logger_message_type);
            return result;
        }

    }
}
