using Arian_project.backend;
using ghest.Backend.Logs;
using System.Collections.Generic;
using System;
using System.Data.SQLite;

namespace Arian_project.Backend
{
    public class services_database
    {

        private log logger = new log();

        Database_data database = new Database_data();
        public List<Service> services_list(string sql_query = "")
        {
            string logger_message_type = "services database";
            logger.record_log("get services list from services table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM services";
            }
            var services = new List<Service>();
            try
            {
                using (var connection = database.connection_to_db())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection))
                    {
                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                services.Add(new Service(reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3)));
                            }
                        }
                    }

                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                logger.record_log(ex.ToString(), logger_message_type);
            }
            return services;

        }


        public int services_counter()
        {
            string logger_message_type = "services_counter";
            string message_type = "get counts of services in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from services";
            result = database.run_one_item_data_query( sql_query, message_type, logger_message_type);
            return result;
        }

        public bool insert_service_to_database(Service service)
        {
            service.id = services_counter() + 1;
            string logger_message_type = "insert_service_to_database";
            string message_type = "insert new service to table";
            bool result = false;
            if (service.id != 0)
            {
                string sql_query = $"INSERT INTO services(id,item_id,service_name,cell_price)VALUES('{service.id}','{service.item_id}','{service.service_name}','{service.cell_price}')";
                result = database.run_sql_query( sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool edite_service_in_datebase(Service service)
        {
            string logger_message_type = "edite_service_in_datebase";
            string message_type = "edite service in services table";
            bool result = false;
            if (service.id != 0)
            {
                string sql_query = $"UPDATE services SET item_id='{service.id}',service_name='{service.service_name}',cell_price='{service.cell_price}' WHERE id='{service.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool delete_service_from_database(int id)
        {
            string logger_message_type = "delete_service_from_database";
            string message_type = "delete service from services table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM services WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
