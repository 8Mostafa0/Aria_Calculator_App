using Arian_project.backend;
using ghest.Backend.Logs;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend
{
    public class Stores_database
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
        public Store get_item_by_id(int id)
        {
            string logger_message_type = "get_item_by_id";
            string message_type = "get stor by id from stors table";
            Store store = null;
            try
            {

            if (id != 0)
            {
                string sql_query = $"SELECT * FROM stors WHERE id='{id}'";
                DataTable dataTable = stores_list(sql_query);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    store = new Store(
                        int.Parse(row["id"].ToString()),
                        int.Parse(row["store_id"].ToString()),
                        row["item_name"].ToString(),
                        decimal.Parse(row["buy_price"].ToString()),
                        decimal.Parse(row["cell_price"].ToString()),
                        int.Parse(row["count"].ToString()),
                        row["buy_date"].ToString(),
                        row["cell_date"].ToString(),
                        row["service_item"].ToString()
                    );
                }
            }
            }catch(Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return store;
        }

        public bool insert_item_to_database(Store store)
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
        public bool edite_item_in_datebase(Store store)
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

        public bool delete_item_from_database(int id)
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
            string message_type = "get storte_ids list from store tabble";
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
        public Store get_item_by_name(string name)
        {

            string logger_message_type = "get_item_by_name";
            string message_type = "get stor by item_name from stors table";
            Store store = null;
            try
            {

                if (name != "")
                {
                    string sql_query = $"SELECT * FROM stors WHERE item_name='{name}'";
                    DataTable dataTable = stores_list(sql_query);
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        store = new Store(
                            int.Parse(row["id"].ToString()),
                            int.Parse(row["store_id"].ToString()),
                            row["item_name"].ToString(),
                            decimal.Parse(row["buy_price"].ToString()),
                            decimal.Parse(row["cell_price"].ToString()),
                            int.Parse(row["count"].ToString()),
                            row["buy_date"].ToString(),
                            row["cell_date"].ToString(),
                            row["service_item"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return store;
        }
        public bool item_exist_in_store(string name)
        {
            string logger_message_type = "item_exist_in_store";
            string message_type = "check item exist in store tabble";
            string sql_query = $"SELECT COUNT(*) FROM stors WHERE item_name='{name}'";
            bool result = false;
            int count = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            if (count > 0) { 
                result = true;
            }
            return result;
        }

        public int get_last_item_store_id()
        {
            string logger_message_type = "get_last_item_store_id";
            string message_type = "get last item store id from store tabble";
            string sql_query = "SELECT store_id FROM stors ORDER BY id DESC LIMIT 1";
            int store_id = database.run_one_item_data_query(sql_query,message_type,logger_message_type);
            return store_id;
        }

        public int get_last_item_id()
        {
            string logger_message_type = "get_last_item_id";
            string message_type = "get last item id from store tabble";
            string sql_query = "SELECT id FROM stors ORDER BY id DESC LIMIT 1";
            int store_id = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return store_id+1;
        }

    }
}
