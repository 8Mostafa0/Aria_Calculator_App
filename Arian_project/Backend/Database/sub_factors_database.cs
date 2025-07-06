using Arian_project.backend;
using ghest.Backend.Logs;
using System.Collections.Generic;
using System.Data.SQLite;
using System;

namespace Arian_project.Backend
{
    public class sub_factors_database
    {


        private log logger = new log();

        Database_data database = new Database_data();
        public List<Sub_factor> sub_factors_list(string sql_query = "")
        {
            string logger_message_type = "sub_factors database";
            logger.record_log("get sub_factor list from sub_factors table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM sub_factors";
            }
            var sub_factors = new List<Sub_factor>();
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
                                sub_factors.Add(new Sub_factor(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3),
                                    reader.GetInt32(4),
                                    reader.GetInt32(5)
                                    ));
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
            return sub_factors;

        }
        public int sub_factors_counter()
        {
            string logger_message_type = "sub_factors_counter";
            string message_type = "get sub_factor of sub_factors in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from sub_factors";
            result = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return result;
        }
        public bool insert_sub_factor_to_database(Sub_factor sub_factor)
        {
            sub_factor.id = sub_factors_counter() + 1;
            string logger_message_type = "insert_sub_factor_to_database";
            string message_type = "insert new sub_facto to sub_factors table";
            bool result = false;
            if (sub_factor.id != 0)
            {
                string sql_query = $"INSERT INTO sub_factors(id,factor_id,item_id,buy_price,cell_price,profit)VALUES('{sub_factor.id}','{sub_factor.factor_id}','{sub_factor.item_id}','{sub_factor.buy_price}','{sub_factor.cell_price}','{sub_factor.profit}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool edite_sub_factor_in_datebase(Sub_factor sub_factor)
        {
            string logger_message_type = "edite_sub_factor_in_datebase";
            string message_type = "edite sub_factor in sub_factors table";
            bool result = false;
            if (sub_factor.id != 0)
            {
                string sql_query = $"UPDATE sub_factors SET factor_id='{sub_factor.factor_id }',item_id='{sub_factor.item_id}',buy_price='{sub_factor.buy_price}',cell_price='{sub_factor.cell_price}',profit='{sub_factor.profit}' WHERE id='{sub_factor.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool delete_sub_factor_from_database(int id)
        {
            string logger_message_type = "delete_sub_factor_from_database";
            string message_type = "delete sub_factor from sub_factors table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM sub_factors WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
