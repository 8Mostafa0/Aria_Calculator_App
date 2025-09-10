using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ghest.Backend.Logs;
using System.Data.SQLite;
namespace Arian_project.backend
{
    public class Database_data
    {
        private readonly static string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private readonly static string database_path= directory + "\\setting";

        public readonly static string database_file = database_path + "\\database.db";
        public static string database { get { return $"DataSource={database_file}"; } set { } }

        private log logger = new log();
        public void check_directorys()
        {
            List<string> directorys = new List<string>
            {
                "\\setting",
                "\\log"
            };
            foreach (string n in directorys)
            {
                if (!Directory.Exists( n))
                {
                    Directory.CreateDirectory(n);
                }
            }
            check_databases();

        }
        public SQLiteConnection connection_to_db()
        {
            var database = Database_data.database;
            var database_connection = new SQLiteConnection(database);
            return database_connection;
        }
        public void check_databases()
        {
            string logger_message_type = "check_databases";
            
            
            try
            {

                if (!Directory.Exists(database_path))
                {
                    Directory.CreateDirectory(database_path);
                }
                if(!File.Exists(database_file))
                {

                    logger.record_log("creating database file and tables", logger_message_type);
            
                    var file_connection = File.Create(database_file);

                    file_connection.Close();

                    string clients_database_sql = "CREATE TABLE 'clients'('id' INT PRIMERY KEY NOT NULL ,user_name TEXT NOT NULL,phone_number TEXT,home_number TEXT,company TEXT,email TEXT,client_type TEXT,client_group TEXT)";

                    string stores_database_sql = "CREATE TABLE stors(id INT PRIMERY KEY NOT NULL ,store_id INT NOT NULL,item_name TEXT NOT NULL,buy_price TEXT NOT NULL,cell_price TEXT NOT NULL,count TEXT NOT NULL,buy_date TEXT NOT NULL,cell_date TEXT NOT NULL,service_item BOOLIAN NOT NULL)";

                    string services_database_sql = "CREATE TABLE services(id INT PRIMERY KEY NOT NULL ,item_id INT NOT NULL,service_name TEXT NOT NULL,cell_price TEXT NOT NULL)";

                    string transactions_database_sql = "CREATE TABLE transactions(id INT PRIMERY KEY NOT NULL ,transaction_type TEXT NOT NULL,bank TEXT NOT NULL,bank_id INT NOT NULL,price TEXT NOT NULL,client_id INT NOT NULL,transaction_date  TEXT NOT NULL,factor_id INT NOT NULL,installment_factor TEXT NOT NULL)";

                    string sms_database_sql = "CREATE TABLE smss(id INT PRIMERY KEY NOT NULL ,client_id INT NOT NULL,phone_number TEXT NOT NULL,sms_status TEXT NOT NULL,sms_date  TEXT NOT NULL)";

                    string factors_database_sql = "CREATE TABLE factors(id INT PRIMERY KEY NOT NULL,client_id int not null,client_name TEXT not null,factor_type TEXT NOT NULL,full_price TEXT NOT NULL,profit TEXT NOT NULL,payed_price TEXT NOT NULL,factor_date TEXT NOT NULL,client_group TEXT NOT NULL,factor_status TEXT NOT NULL)";

                    string sub_factors_database_sql = "CREATE TABLE sub_factors(id INT PRIMERY KEY NOT NULL ,factor_id INT NOT NULL,item_id INT NOT NULL,buy_price TEXT NOT NULL,cell_price TEXT NOT NULL,profit TEXT NOT NULL,count INT NOT NULL)";

                    string banks_database_sql = "CREATE TABLE banks(id INT PRIMARY KEY NOT NULL,name TEXT NOT NULL,bank_type TEXT NOT NULL,balance TEXT NOT NULL)";

                    string card_readers_database_sql = "CREATE TABLE card_readers(id INT PRIMARY KEY NOT NULL,bank_id INT NOT NULL,name TEXT NOT NULL)";

                    string client_installments_database_sql = "CREATE TABLE client_installments(id INT PRIMARY KEY NOT NULL,client_id INT NOT NULL,client_name TEXT NOT NULL,factor_id INT NOT NULL,installment_price  TEXT NOT NULL,first_installment TEXT NOT NULL,one_installment_price TEXT NOT NULL,installment_count TEXT NOT NULL,installment_payed_count TEXT NOT NULL,end_installment TEXT NOT NULL,sms_days TEXT NOT NULL)";

                    string installment_transaction_database_sql = "CREATE TABLE installment_transactions(id INT PRIMARY KEY NOT NULL,date TEXT NOT NULL,price TEXT NOT NULL,payed_price TEXT NOT NULL,penalty_type TEXT NOT NULL,penalty_price_per_day TEXT NOT NULL,penalty TEXT NOT NULL,status TEXT NOT NULL,installment_number TEXT NOT NULL,installment_id TEXT NOT NULL)";
                    
                    using (var database_connection = connection_to_db())
                    {
                        database_connection.Open();

                        using (var command = new SQLiteCommand(clients_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(stores_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        using (var command = new SQLiteCommand(services_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        using (var command = new SQLiteCommand(transactions_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        using (var command = new SQLiteCommand(sms_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        using (var command = new SQLiteCommand(factors_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        using (var command = new SQLiteCommand(sub_factors_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(banks_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(card_readers_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(client_installments_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(installment_transaction_database_sql, database_connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        database_connection.Close();
                    }
                }
            }
            catch (Exception ex) {
                logger.record_log(ex.ToString(), logger_message_type);
            }
        }
        public bool run_sql_query(string sql_query,string message_type,string logger_message_type) {

            logger.record_log(message_type, logger_message_type);
            bool result = false;
            try
            {
                var connection = connection_to_db();
                connection.Open();
                using (var command = new SQLiteCommand(sql_query, connection))
                {
                    result = command.ExecuteNonQuery() > 0;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                logger.record_log(ex.ToString(), logger_message_type);
            }
            return result;
        }

        public int run_one_item_data_query( string sql_query, string message_type, string logger_message_type)
        {
            int count = 0;
            logger.record_log(message_type, logger_message_type);
            try
            {
                var connection = connection_to_db();
                connection.Open();
                var command = new SQLiteCommand(sql_query, connection);
                count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }catch(Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                logger.record_log(ex.ToString(), logger_message_type);
            }
            return count;
        }

        public int get_one_data_query(string sql_query, string message_type, string logger_message_type)
        {
            try
            {
                logger.record_log(message_type, logger_message_type);
                var connection = connection_to_db();
                connection.Open();
                int counts = 0;
                var command = new SQLiteCommand(sql_query, connection);

                object count = command.ExecuteScalar(); 

                if (count != null && count.ToString() != "")
                {
                    counts = Convert.ToInt32(count.ToString());
                }
                connection.Close();
                return counts;
            }   
            catch (Exception ex) {
                logger.record_log(ex.ToString(), logger_message_type);
                return 0;
            }
        }
    }

}