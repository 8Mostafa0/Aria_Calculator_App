using Arian_project.backend;
using ghest.Backend.Logs;
using System.Collections.Generic;
using System;
using System.Data.SQLite;
using System.Data;

namespace Arian_project.Backend
{
    public class Services_database
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

        public DataTable get_services_datatable(string sql_query = "")
        {
            string logger_message_type = "get_services_datatable";
            logger.record_log("get services from services table", logger_message_type);
            if (string.IsNullOrEmpty(sql_query))
            {
                sql_query = "SELECT * FROM services";
            }
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = database.connection_to_db())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
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
            return dataTable;
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

        public DataTable get_items_not_in_services(string sql_query = "")
        {
            string logger_message_type = "get_items_not_in_services";
            string message_type = "Get All items from stores table which not added on services table";

            if (sql_query == "")
            {
                sql_query = "SELECT * FROM stors LEFT JOIN services ON stors.id = services.item_id WHERE services.item_id IS NULL";
            }

            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = database.connection_to_db())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                logger.record_log(ex.ToString(), message_type);
            }
            return dataTable;
        }

        public int get_last_service_id()
        {
            int id = 0;
            string message_type = "get_last_service_id";
            string logger_message_type = "get last service id from services table";
            string sql_query = $"SELECT MAX(id) FROM services";
            id = database.get_one_data_query(sql_query, message_type, logger_message_type);
            return id;
        }

        public bool store_item_exist_in_services_database(int item_id)
        {
            string message_type = "store_item_exist_in_services_database";
            string logger_message_type = "check store item exists in services table";
            string sql_query = $"SELECT COUNT(*) FROM services WHERE item_id='{item_id}'";
            bool result = database.get_one_data_query(sql_query,message_type,logger_message_type) > 1;
            return result;
        }
        public Service get_Service_by_id(int id)
        {
            string message_type = "get_Service_by_id";
            string logger_message_type = "get service by id from services table";
            string sql_query = $"SELECT * FROM services WHERE id='{id}'";
            Service service = null;
            try
            {
                using (SQLiteConnection connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql_query, connection))
                    {
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                service = new Service(
                                        reader.GetInt32(0),
                                        reader.GetInt32(1),
                                        reader.GetString(2),
                                        reader.GetDecimal(3)
                                    );
                            }
                        }

                        connection.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return service;

        }
    }
}
