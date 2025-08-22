using Arian_project.backend;
using ghest.Backend.Logs;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend
{
    public class stores_database
    {
        private log logger = new log();

        Database_data database = new Database_data();
        public DataTable stores_list(string sql_query = "")
        {
            string logger_message_type = "stors database";
            logger.record_log("get stors list from stors table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM stors";
            }
            DataTable stors = new DataTable();
            try
            {
                using (var connection = database.connection_to_db())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(stors);
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
        public List<string> list_stores()
        {
            string logger_message_type = "list_stores";
            string message_type = "get storte_ids list from tabble";
            List<string> store_ids = new List<string>();
            string sql_query = "SELECT DISTINCT store_id FROM stors";
            DataSet dataSet = new DataSet();
            try
            {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql_query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataSet);
                        }
                    }
                    connection.Close();
                }
                if (dataSet.Tables.Count > 0)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        store_ids.Add(row["store_id"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return store_ids;
        }
    }
}
