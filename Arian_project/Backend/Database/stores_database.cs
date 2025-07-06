using System.Collections.Generic;
using System.Data.SQLite;
using System;
using Arian_project.backend;
using ghest.Backend.Logs;

namespace Arian_project.Backend
{
    public class stores_database
    {
        private log logger = new log();

        Database_data database = new Database_data();
        public List<Store> stores_list(string sql_query = "")
        {
            string logger_message_type = "stors database";
            logger.record_log("get stors list from stors table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM stors";
            }
            var stors = new List<Store>();
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
                                stors.Add(new Store(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3),
                                    reader.GetInt32(4),
                                    reader.GetInt32(5),
                                    reader.GetString(6),
                                    reader.GetString(7),
                                    Convert.ToBoolean(reader.GetString(8))));
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
            return stors;

        }
        public int stores_counter()
        {
            string logger_message_type = "stores_counter";
            string message_type = "get stors of stors in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from stors";
            result = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return result;
        }
        public bool insert_service_to_database(Store store)
        {
            store.id = stores_counter() + 1;
            string logger_message_type = "insert_service_to_database";
            string message_type = "insert new stor to stors table";
            bool result = false;
            if (store.id != 0)
            {
                string sql_query = $"INSERT INTO stors(id,store_id,item_name,buy_price,cell_price,count,buy_date,cell_date,service_item)VALUES('{store.id}','{store.store_id}','{store.item_name}','{store.buy_price}','{store.cell_price}','{store.count}','{store.buy_date}','{store.cell_date}','{store.service_item}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool edite_stor_in_datebase(Store store)
        {
            string logger_message_type = "edite_stor_in_datebase";
            string message_type = "edite stor in stors table";
            bool result = false;
            if (store.id != 0)
            {
                string sql_query = $"UPDATE stors SET store_id='{store.store_id}',item_name='{store.item_name}',buy_price='{store.buy_price}',cell_price='{store.cell_price}',count='{store.count}',buy_date='{store.buy_date}',cell_date='{store.cell_date}',service_item='{store.service_item}' WHERE id='{store.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool delete_stor_from_database(int id)
        {
            string logger_message_type = "delete_stor_from_database";
            string message_type = "delete stor from stors table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM stors WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
