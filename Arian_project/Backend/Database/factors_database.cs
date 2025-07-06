
using System.Collections.Generic;
using System;
using System.Data.SQLite;
using Arian_project.backend;
using ghest.Backend.Logs;

namespace Arian_project.Backend
{
    public class factors_database
    {

        private log logger = new log();

        Database_data database = new Database_data();

        public List<Factor> factors_list(string sql_query = "")
        {
            string logger_message_type = "factors database";
            logger.record_log("get factors list from factorss table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM factors";
            }
            var factors = new List<Factor>();
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
                                factors.Add(new Factor(reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetInt32(3),
                                    reader.GetString(4),
                                    reader.GetString(5)));
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
            return factors;

        }

        public int factors_counter()
        {
            string logger_message_type = "factors_counter";
            string message_type = "get counts of factors in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from factors";
            result = database.run_one_item_data_query( sql_query, message_type, logger_message_type);
            return result;
        }

        public bool insert_factor_to_database(Factor factor)
        {
            factor.id = factors_counter()+1;
            string logger_message_type = "insert_factor_to_database";
            string message_type = "insert new factor to table";
            bool result = false;
            if (factor.id != 0)
            {
                string sql_query = $"INSERT INTO factors(id,client_id,full_price,profit,factor_date,client_group)VALUES('{factor.id}','{factor.client_id}','{factor.full_price}','{factor.profit}','{factor.factor_date}','{factor.client_group}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool edite_factor_in_datebase(Factor factor) {
            string logger_message_type = "edite_factor_in_datebase";
            string message_type = "edite factor in factors table";
            bool result = false;
            if (factor.id != 0) {
                string sql_query = $"UPDATE factors SET client_id='{factor.client_id}',full_price='{factor.full_price}',profit='{factor.profit}',factor_date='{factor.factor_date}',client_group='{factor.client_group}' WHERE id='{factor.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool delete_factor_from_database(int id) {
            string logger_message_type = "delete_factor_from_database";
            string message_type = "delete factor from factors table";
            bool result = false;
            if (id != 0) {
                string sql_query = $"DELETE FROM factors WHERE id='{id}'";
                result = database.run_sql_query(sql_query,message_type, logger_message_type);
            }
            return result;
        }

    }
}
