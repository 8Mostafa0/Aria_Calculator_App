using Arian_project.backend;
using ghest.Backend.Logs;
using System.Collections.Generic;
using System;
using System.Data.SQLite;

namespace Arian_project.Backend
{
    public class smss_database
    {

        private log logger = new log();

        Database_data database = new Database_data();
        public List<Sms> smss_list(string sql_query = "")
        {
            string logger_message_type = "smss database";
            logger.record_log("get smss list from services table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM smss";
            }
            var smss = new List<Sms>();
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
                                smss.Add(new Sms(reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4)));
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
            return smss;

        }
        public int smss_counter()
        {
            string logger_message_type = "smss_counter";
            string message_type = "get counts of smss in table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from smss";
            result = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return result;
        }
        public bool insert_service_to_database(Sms sms)
        {
            sms.id = smss_counter() + 1;
            string logger_message_type = "insert_smss_to_database";
            string message_type = "insert new sms to smss table";
            bool result = false;
            if (sms.id != 0)
            {
                string sql_query = $"INSERT INTO smss(id,client_id,phone_number,sms_status,sms_date)VALUES('{sms.id}','{sms.client_id}','{sms.phone_number}','{sms.sms_status}','{sms.sms_date}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool edite_sms_in_datebase(Sms sms)
        {
            string logger_message_type = "edite_sms_in_datebase";
            string message_type = "edite sms in smss table";
            bool result = false;
            if (sms.id != 0)
            {
                string sql_query = $"UPDATE smss SET client_id='{sms.id}',phone_number='{sms.phone_number}',sms_status='{sms.sms_status}',sms_date='{sms.sms_date}' WHERE id='{sms.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public bool delete_sms_from_database(int id)
        {
            string logger_message_type = "delete_sms_from_database";
            string message_type = "delete sms from smss table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = $"DELETE FROM smss WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    }
}
