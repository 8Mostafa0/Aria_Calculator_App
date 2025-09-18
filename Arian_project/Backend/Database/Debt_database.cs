using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend.Database
{
    public class Debt_database
    {
        private log logger = new log();
        Database_data database = new Database_data();
        public DataTable get_debts_datatable(string sql_query) {
            string logger_message_type = "get_debts_datatable";
            logger.record_log("get debts list from debts table", logger_message_type);
            if (string.IsNullOrEmpty(sql_query))
            {
                sql_query = "SELECT * FROM debts";
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
        public List<Debt> get_debts_list(string sql_query) {

            string logger_message_type = "get_debts_list";
            logger.record_log("get debts list from debts table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM factors";
            }
            var debts = new List<Debt>();
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
                                debts.Add(new Debt(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetDecimal(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetInt32(6),
                                    reader.GetString(7)
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
            return debts;
        }

        public bool insert_debt_to_db(Debt debt)
        {
            string logger_message_type = "insert_debt_to_db";
            string message_type = "insert new debt to debts table";
            bool result = false;
            if (debt.id != 0)
            {
                string sql_query = $"INSERT INTO debts(id,name,price,date,description,bank_id,bank_name)VALUES('{debt.id}','{debt.name}','{debt.price}','{debt.date}','{debt.description}','{debt.bank_id}','{debt.bank_name}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool update_debt_to_db(Debt debt)
        {
            string logger_message_type = "update_debt_to_db";
            string message_type = "edite debt in debts table";
            bool result = false;
            if (debt.id != 0)
            {
                string sql_query = $"UPDATE debts SET name='{debt.name}',price'{debt.price}',date'{debt.date}',desciption'{debt.description}',bank_id='{debt.bank_id}',bank_name='{debt.bank_name}' WHERE id='{debt.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        
        public bool delete_debt_to_db(int id) {
            string logger_message_type = "delete_debt_to_db";
            string message_type = "delete debt from debts table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM debts WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public int get_last_debt_id() {
            string message_type = "get_last_debt_id";
            string logger_message_type = "get last debt id from debts table";
            string sql_query = "SELECT MAX(id) FROM debts";
            return database.run_one_item_data_query(sql_query, message_type, logger_message_type);
        }

    }

}
