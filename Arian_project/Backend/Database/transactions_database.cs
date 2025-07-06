using Arian_project.backend;
using ghest.Backend.Logs;
using System.Collections.Generic;
using System.Data.SQLite;
using System;

namespace Arian_project.Backend
{
    public class transactions_database
    {

        private log logger = new log();

        Database_data database = new Database_data();
        public List<Transaction> transactions_list(string sql_query = "")
        {
            string logger_message_type = "transactions database";
            logger.record_log("get transactions list from transactions table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM transactions";
            }
            var transactions = new List<Transaction>();
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
                                transactions.Add(new Transaction(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3),
                                    reader.GetInt32(4),
                                    reader.GetString(5),
                                    reader.GetString(6)
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
            return transactions;

        }
        public int transactions_counter()
        {
            string logger_message_type = "transactions_counter";
            string message_type = "get counts of transactions in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from transactions";
            result = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return result;
        }
        public bool insert_transaction_to_database(Transaction transaction)
        {
            transaction.id = transactions_counter() + 1;
            string logger_message_type = "insert_transaction_to_database";
            string message_type = "insert new transaction to transactions table";
            bool result = false;
            if (transaction.id != 0)
            {
                string sql_query = $"INSERT INTO transactions(id,transaction_type,bank,price,client_id,transaction_date,transaction_status)VALUES('{transaction.id}','{transaction.transaction_type}','{transaction.bank}','{transaction.price}','{transaction.client_id}','{transaction.transaction_date}','{transaction.transaction_status}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool edite_transaction_in_datebase(Transaction transaction)
        {
            string logger_message_type = "edite_transaction_in_datebase";
            string message_type = "edite transaction in transactions table";
            bool result = false;
            if (transaction.id != 0)
            {
                string sql_query = $"UPDATE transactions SET transaction_type='{transaction.transaction_type}',bank='{transaction.bank}',price='{transaction.price}',client_id='{transaction.client_id}',transaction_date='{transaction.transaction_date}',transaction_status='{transaction.transaction_status}' WHERE id='{transaction.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool delete_transaction_from_database(int id)
        {
            string logger_message_type = "delete_transaction_from_database";
            string message_type = "delete transaction from transactions table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM transactions WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
