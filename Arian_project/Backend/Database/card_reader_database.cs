using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Arian_project.Backend
{
    internal class Card_reader_database
    {
        private log logger = new log();
        Database_data database = new Database_data();

        public int card_readers_count()
        {
            int card_readers_count = 0;
            string logger_message_type = "card_readers_count";
            string message_type = "get card readers count from card_reader table";
            string sql_query = "SELECT COUNT(*) card_readers";
            card_readers_count = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            return card_readers_count;

        }
        public Card_Reader get_card_reader_by_name(string name)
        {
            string logger_message_type = "get_card_reader_by_name";
            string message_type = "get card reader by name from card_readers table";
            string sql_query = $"SELECT * FROM card_readers WHERE name='{name}'";
            Card_Reader card_r = new Card_Reader(0, "0", 0);
            try
            {
                using (var connection = new Database_data().connection_to_db())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql_query, connection))
                    {
                        using (var adapter = command.ExecuteReader())
                        {
                            if (adapter.HasRows)
                            {
                                while (adapter.Read())
                                {
                                    card_r = new Card_Reader(
                                        adapter.GetInt32(0),
                                        adapter.GetString(2),
                                        adapter.GetInt32(1)
                                        );
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                logger.record_log("SQL QUERY => " + sql_query, message_type);
                logger.record_log(ex.ToString(), logger_message_type);
            }
            return card_r;
        }
        public int get_last_card_reader_id()
        {
            int last_card_reader_id = 0;
            string logger_message_type = "get_last_card_reader_id";
            string message_type = "get last card reader id from card_readers table";
            string sql_query = "SELECT MAX(id) FROM card_readers";
            if(card_readers_count() > 0)
            {
                last_card_reader_id = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            }
            return last_card_reader_id;
        }



        public List<Card_Reader> card_readers_list_array(string sql_query = "")
        {
            string logger_message_type = "card_readers_list_string";
            string message_type = "get card readers list from card_reader table";
            logger.record_log(message_type, logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM card_readers";
            }
            List<Card_Reader> data = new List<Card_Reader>();
            try
            {
                if(card_readers_count() > 0)
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
                                    Card_Reader item = new Card_Reader(
                                        adapter.GetInt32(0),
                                        adapter.GetString(2),
                                        adapter.GetInt32(1)
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

        public DataTable card_readers_list(string sql_query = "") {
            string logger_message_type = "card_readers_list";
            string message_type = "get card readers list from card_reader table";
            logger.record_log(message_type, logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM card_readers";
            }
            DataTable dataTable = new DataTable();
            if(card_readers_count()> 0)
            {
                try
                {
                    using(var connection = database.connection_to_db())
                    {
                        connection.Open();
                        using (var command = new SQLiteCommand(sql_query, connection))
                        {
                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command)) { 
                        
                                adapter.Fill(dataTable);
                        
                            }
                        }
                        connection.Close();
                    }
                }catch(Exception ex)
                {
                    logger.record_log("SQL QUERY => " + sql_query, logger_message_type);
                    logger.record_log(ex.ToString(), logger_message_type);
                }
            }
            return dataTable;
        }


        public bool insert_card_reader_to_database(Card_Reader card_reader)
        {
           
            string logger_message_type = "insert_card_reader_to_database";
            string message_type = "insert card reader to card_readers table";
            bool result = false;
            if(card_reader.id != 0)
            {
                string sql_query = $"INSERT INTO card_readers(id,bank_id,name)VALUES('{card_reader.id}','{card_reader.bank_id}','{card_reader.name}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);    
            }
            return result;
        }

        public bool edite_card_reader_in_database(Card_Reader card_readr)
        {
            string logger_message_type = "edite_card_reader_in_database";
            string message_type = "edite card reader in card_readrs table";
            bool result = false;
            if(card_readr.id != 0)
            {
                string sql_query = $"UPDATE card_readers SET bank_id='{card_readr.bank_id}',name='{card_readr.name}' WHERE id='{card_readr.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }


        public bool delete_card_reader_from_database(int id)
        {
            string logger_message_type = "delete_card_reader_from_database";
            string message_type = "delete card reader from card_readrs table";
            bool result = false;
            if (id != 0) {
                string sql_query = $"DELETE FROM card_readers WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
