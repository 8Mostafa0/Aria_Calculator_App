using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend.Database
{
    public class Banks_database
    {
        private Users_database userlog = new Users_database();
        
        private log logger = new log();
        Database_data database = new Database_data();

        public int banks_count()
        {
            int banks_count = 0;
            string message_type = "get banks count from banks table";
            string logger_message_type = "banks_count";
            string sql_query = "SELECT COUNT(*) FROM banks";
            banks_count = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            return banks_count;
        }

        public DataTable Banks_list(string sql_query = "")
        {
            string logger_message_type = "banks database";
            logger.record_log("get banks list from banks table", logger_message_type);
            if(sql_query == "")
            {
                sql_query = "SELECT * FROM banks";
            }
            DataTable dataTable = new DataTable();
            try
            {
                using(var connection = database.connection_to_db())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sql_query, connection)) 
                    { 
                        using(SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }    
                    }
                    connection.Close();
                }
            }catch( Exception ex)
            {
                logger.record_log("SQL QUERY => "+sql_query,logger_message_type);
                logger.record_log(ex.ToString(),logger_message_type);
            }
            return dataTable;
        }

        public bool insert_bank_to_database(Bank bank)
        {
            string logger_message_type = "insert_bank_to_database";
            string message_type = "insert new bak to banks table";
            bool result = false;
            if(bank.id != 0)
            {
                string sql_qery = $"INSERT INTO banks(id,name,bank_type,balance)VALUES('{bank.id}','{bank.name}','{bank.bank_type}','{bank.balance}')";
                result = database.run_sql_query(sql_qery, message_type, logger_message_type);
            }
            return result;
        }

        public bool edite_bank_in_database(Bank bank) 
        {
            string message_type = "edite_bank_in_database";
            string logger_message_type = "edite bank in banks table";
            bool result = false;
            if (bank.id != 0) {
                string sql_query = $"UPDATE banks SET name='{bank.name}',bank_type='{bank.bank_type}',balance='{bank.balance}' WHERE id ='{bank.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool delete_bank_from_database(int id) {
            string logger_message_type = "delete_bank_from_database";
            string message_type = "delete bank from banks table";
            bool result = false;
            if (id != 0) {
                string sql_query = $"DELETE FROM banks WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);

            }
            return result;
        }

        public List<string> get_bank_types()
        {
            string logger_message_type = "get_bank_types";
            string message_type = "get bank types from banks tabble";
            List<string> bank_types = new List<string>();
            string sql_query = "SELECT DISTINCT bank_type FROM banks";
            DataSet dataSet = new DataSet();
            try {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using(SQLiteCommand command = new SQLiteCommand(sql_query, connection))
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
                        bank_types.Add(row["bank_type"].ToString());
                    }
                }
            }
            catch (Exception ex) {
                logger.record_log("SQL QUERY => "+ex,logger_message_type);
                logger.record_log(message_type,logger_message_type);
            }
            return bank_types;
        }

        public Bank get_bank_data_by_name(string name)
        {
            string logger_message_type = "get_bank_data";
            string message_type = "get bank data from banks tabble";
            Bank bank_data = new Bank(0,"0", "0",0);
            string sql_query = $"SELECT * FROM banks WHERE name Like '%{name}%'";
            DataTable dataSet = new DataTable();
            try
            {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql_query, connection))
                    {
                        using (var adapter = command.ExecuteReader())
                        {
                            while (adapter.Read())
                            {
                                bank_data = new Bank(
                                    adapter.GetInt32(0),
                                    adapter.GetString(1),
                                    adapter.GetString(2),
                                    adapter.GetDecimal(3)
                                    );
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return bank_data;
        }
        public Bank get_bank_data_by_id(int id)
        {

            string logger_message_type = "get_bank_data";
            string message_type = "get bank data from banks tabble";
            Bank bank_data = new Bank(0, "0", "0", 0);
            string sql_query = $"SELECT * FROM banks WHERE id='{id}'";
            DataSet dataSet = new DataSet();
            try
            {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql_query, connection))
                    {
                        using (var adapter = command.ExecuteReader())
                        {
                            while (adapter.Read())
                            {
                                bank_data = new Bank(
                                    adapter.GetInt32(0),
                                    adapter.GetString(1),
                                    adapter.GetString(2),
                                    adapter.GetDecimal(3)
                                    );
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return bank_data;
        }
        public Bank get_bank_by_name(string name)
        {
            string logger_message_type = "get_bank_name";
            string message_type = "get bank names from banks tabble";
            Bank bank = null;
            ;
            try
            {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM banks WHERE name='{name}'", connection))
                    {
                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bank = new Bank(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetDecimal(3)
                                    );
                            }
                        }
                    }
                    connection.Close();
                }
            }catch(Exception ex)
            {

                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return bank;
        }
        public List<string> get_banks_name()
        {
            string logger_message_type = "get_bank_name";
            string message_type = "get bank names from banks tabble";
            List<string> bank_types = new List<string>();
            string sql_query = "SELECT DISTINCT name FROM banks";
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
                        bank_types.Add(row["name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + ex, logger_message_type);
                logger.record_log(message_type, logger_message_type);
            }
            return bank_types;
        }
    }
}
