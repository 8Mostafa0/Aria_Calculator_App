using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ghest.Backend.Logs;
using System.Data.SQLite;
namespace Arian_project.backend.Database
{
    public class Database_data
    {
        private readonly static string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private readonly static string database_path= directory + "\\setting";

        public readonly static string database_file = database_path + "\\database.db";
        public static string database { get { return $"DataSource={database_file}"; } set { } }

        public void check_directorys()
        {
            List<string> directorys = new List<string>
            {
                "\\setting",
                "\\log"
            };
            foreach (string n in directorys)
            {
                if (!Directory.Exists(directory + n))
                {
                    Directory.CreateDirectory(directory + n);
                    check_databases();
                }
            }

        }

        public void check_databases()
        {
            string log_message_type = "check_databases";
            
            log logger = new log();
            
            try
            {
                logger.record_log("creating database file and tables", log_message_type);

                if (!Directory.Exists(database_path))
                {
                    Directory.CreateDirectory(database_path);
                }
                else
                {

            
                var file_connection = File.Create(database_file);

                file_connection.Close();

                string clients_database_sql = "CREATE TABLE 'clients'('id' INT PRIMERY KEY NOT NULL,user_name TEXT NOT NULL,phone_number TEXT,home_number TEXT,company TEXT,email TEXT,client_type TEXT,client_group TEXT)";

                string stores_database_sql = "CREATE TABLE store(id INT PRIMERY KEY NOT NULL,store_id INT NOT NULL,item_name TEXT NOT NULL,buy_price INT NOT NULL,cell_price TEXT NOT NULL,count INT NOT NULL,buy_date TEXT NOT NULL,cell_date TEXT NOT NULL,service_item BOOLIAN NOT NULL)";

                string services_database_sql = "CREATE TABLE services(id INT PREIMERY KEY NOT NULL,item_id INT NOT NULL,service_name TEXT NOT NULL,cell_price INT NOT NULL)";

                string transactions_database_sql = "CREATE TABLE transactions(id INT PRIMERY KEY NOT NULL,transaction_type TEXT NOT NULL,bank TEXT NOT NULL,price INT NOT NULL,client_id INT NOT NULL,transaction_date  TEXT NOT NULL,transaction_status TEXT NOT NULL)";

                string sms_database_sql = "CREATE TABLE sms(id INT PRIMERY KEY NOT NULL,client_id INT NOT NULL,phone_number TEXT NOT NULL,sms_status TEXT NOT NULL,sms_date  TEXT NOT NULL)";

                string factors_database_sql = "CREATE TABLE factors(id INT PRIMERY KEY NOT NULL,client_id int not null,full_price INT NOT NULL,profit INT NOT NULL,factor_date TEXT NOT NULL,client_group TEXT NOT NULL)";

                string sub_factors_database_sql = "CREATE TABLE sub_factors(id INT PRIMERY KEY NOT NULL,factor_id INT NOT NULL,item_id INT NOT NULL,buy_prce INT NOT NULL,cell_price INT NOT NULL,profit INT NOT NULL)";

                using (var database_connection = new SQLiteConnection(database))
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

                    database_connection.Close();
                }
                }
            }
            catch (Exception ex) {
                logger.record_log(ex.ToString(), log_message_type);
            }
        }


    }
}
