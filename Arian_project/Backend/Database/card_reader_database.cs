using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend
{
    internal class card_reader_database
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

        public DataTable card_readers_list(string sql_query = "") {
            string logger_message_type = "card_readers_list";
            string message_type = "get card readers list from card_reader table";
            logger.record_log(message_type, logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM card_readers";
            }
            DataTable dataTable = new DataTable();
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
