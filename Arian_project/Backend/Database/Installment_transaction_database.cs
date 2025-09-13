using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Arian_project.Backend.Database
{
    internal class Installment_transaction_database
    {
        private log logger = new log();
        Database_data database = new Database_data();

        public List<Installment_transaction> get_installment_transactions_list(string sql_query) {

            string logger_message_type = "get_installment_transactions_list";
            string message_type = "get installment transactions list from installment_transactions table";
            logger.record_log(message_type, logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM installment_transactions";
            }
            List<Installment_transaction> data = new List<Installment_transaction>();
            try
            {
                if (get_installment_transactions_count() > 0)
                {
                    using (var connection = database.connection_to_db())
                    {
                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = sql_query;
                            using (var adapter = command.ExecuteReader())
                            {
                                while (adapter.Read())
                                {
                                    Installment_transaction item = new Installment_transaction(
                                        adapter.GetInt32(0),
                                        adapter.GetString(1),
                                        adapter.GetDecimal(2),
                                        adapter.GetDecimal(3),
                                        adapter.GetString(4),
                                        adapter.GetDecimal(5),
                                        adapter.GetDecimal(6),
                                        adapter.GetString(7),
                                        int.Parse(adapter.GetString(8)),
                                        int.Parse(adapter.GetString(9))
                                        );
                                    data.Add(item);
                                }
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                logger.record_log(ex.ToString(), logger_message_type);
            }
            return data;
        }

        public bool insert_installment_transaction_to_database(Installment_transaction transaction)
        {
            string logger_message_type = "insert_card_reader_to_database";
            string message_type = "insert card reader to card_readers table";
            bool result = false;
            if (transaction.id != 0)
            {
                string sql_query = $"INSERT INTO installment_transactions(id,date,price,payed_price,penalty_type,penalty_price_per_day,penalty,status,installment_number,installment_id)VALUES('{transaction.id}','{transaction.date}','{transaction.price}','{transaction.payed_price}','{transaction.penalty_type}','{transaction.penalty_price_per_day}','{transaction.penalty}','{transaction.status}','{transaction.installment_number}','{transaction.installment_id}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool edite_installment_transaction_to_database(Installment_transaction transaction)
        { 
            string logger_message_type = "edite_installment_transaction_to_database";
            string message_type = "edite installment transaction in installment_transactions table";
            bool result = false;
            if (transaction.id != 0)
            {
                string sql_query = $"UPDATE installment_transactions SET date='{transaction.date}',price='{transaction.price}',payed_price='{transaction.payed_price}',penalty_type='{transaction.penalty_type}',penalty_price_per_day='{transaction.penalty_price_per_day}',penalty='{transaction.penalty}',status='{transaction.status}',installment_number ='{transaction.installment_number}'WHERE id='{transaction.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool delete_installment_transaction_from_database(int id)
        {
            string logger_message_type = "delete_installment_transaction_from_database";
            string message_type = "delete installment transaction from installment_transactions table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM installment_transactions WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public int get_installment_transactions_count()
        {
            int installment_transactions_count = 0;
            string logger_message_type = "get_installment_transactions_count";
            string message_type = "get installment transactions count from installment_transactions table";
            string sql_query = "SELECT COUNT(*) installment_transactions";
            installment_transactions_count = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            return installment_transactions_count;
        }
        public int get_last_installment_transaction_id()
        {
            int installment_transactions_id = 0;
            string logger_message_type = "get_last_installment_transactions_id";
            string message_type = "get installment transactions count from installment_transactions table";
            string sql_query = "SELECT MAX(id) FROM installment_transactions";
            installment_transactions_id = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            installment_transactions_id+=1;
            return installment_transactions_id;
        }
    }
}
