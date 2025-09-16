using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Xml.Linq;

namespace Arian_project.Backend.Database
{
    internal class Client_installment_database
    {
        private log logger = new log();
        Database_data database = new Database_data();

        public DataTable get_client_installment_datatable(string sql_query="") {
            string logger_message_type = "get_client_installment_datatable";
            logger.record_log("get client installment from client_installment list into datatable", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM client_installments";
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

        public List<Client_Installment> get_client_installment_list(string sql_query="")
        {


            string logger_message_type = "get_client_installment_list";
            logger.record_log("get client installments from client installment table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM client_intallments";
            }
            var client_intallments = new List<Client_Installment>();
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
                                client_intallments.Add(
                                new Client_Installment(
                                        reader.GetInt32(0),
                                        reader.GetInt32(1),
                                        reader.GetString(2),
                                        reader.GetInt32(3),
                                        reader.GetDecimal(4),
                                        reader.GetString(5),
                                        reader.GetDecimal(6),
                                        reader.GetInt32(7),
                                        reader.GetInt32(8),
                                        reader.GetBoolean(9),
                                        reader.GetInt32(10),
                                        reader.GetInt32(11),
                                        reader.GetString(12)
                                        )
                                    );
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
            return client_intallments;
        }
        public bool insert_client_installment_to_database(Client_Installment installment)
        {
            string logger_message_type = "insert_client_installment_to_database";
            string message_type = "insert new client installmet into client_isntallments table";
            bool result = false;
            if (installment.id != 0)
            {
                string sql_query = $"INSERT INTO client_installments(id,client_id,client_name,factor_id,installment_price,first_installment,one_installment_price,installment_count,installment_payed_count,end_installment,next_reminder,sms_days,status)VALUES('{installment.id}','{installment.client_id}','{installment.client_name}','{installment.factor_id}','{installment.installment_price}','{installment.first_installment}','{installment.one_installment_price}','{installment.installment_count}','{installment.installment_payed_count}','{installment.end_instllment}','{installment.next_reminder}','{installment.sms_days}','{installment.status}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
    
        public bool update_client_installment_to_database(Client_Installment installment) {
            string logger_message_type = "update_client_installment_to_database";
            string message_type = "update client installmet in client_isntallments table";
            bool result = false;
            if (installment.id != 0)
            {
                string sql_query = $"UPDATE client_installments SET client_id='{installment.client_id}',client_name='{installment.client_name}',factor_id='{installment.factor_id}',installment_price='{installment.installment_price}',first_installment='{installment.first_installment}',one_installment_price='{installment.one_installment_price}',installment_count='{installment.installment_count}',installment_payed_count='{installment.installment_payed_count}',end_installment='{installment.end_instllment}',sms_days='{installment.sms_days}',status='{installment.status}' WHERE id='{installment.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool delete_client_installment_from_database(int id) {
            string logger_message_type = "delete_client_installment_from_database";
            string message_type = "delete clintclient installment from  client_isntallments table";
            bool result = false;
            if (id != 0)
            {
                string sql_query = "DELETE * FROM client_installments WHERE id='{id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }
        public int get_client_installment_count()
        {
            string logger_message_type = "get_client_installment_count";
            string message_type = "get count client installment from client_installments table";
            int result = 0;
            string sql_query = $"SELECT COUNT(*) from client_installments";
            result = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            return result;
        }

        public int get_last_client_installment_id(string sql_query="") {

            int last_card_reader_id =0;
            string logger_message_type = "get_last_card_reader_id";
            string message_type = "get last card reader id from card_readers table";
            if (sql_query == "") { 
                sql_query = "SELECT MAX(id) FROM client_installments";
            }
            if (get_client_installment_count() > 0)
            {
                last_card_reader_id = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            }
            last_card_reader_id += 1;
            return last_card_reader_id;
        }

        public Client_Installment get_installment_by_id(int id) {
            string logger_message_type = "get_installment_by_id";
            string message_type = "get client isntallment from client_installments tabble";
            Client_Installment installment= new Client_Installment(0,0,"",0,0,"",0,0,0,true,0,0);
            string sql_query = $"SELECT * FROM client_installments WHERE id='{id}'";
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
                                installment = new Client_Installment(
                                        adapter.GetInt32(0),
                                        adapter.GetInt32(1),
                                        adapter.GetString(2),
                                        adapter.GetInt32(3),
                                        adapter.GetDecimal(4),
                                        adapter.GetString(5),
                                        adapter.GetDecimal(6),
                                        adapter.GetInt32(7),
                                        adapter.GetInt32(8),
                                        adapter.GetBoolean(9),
                                        adapter.GetInt32(10),
                                        adapter.GetInt32(11),
                                        adapter.GetString(12)
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
            return installment;
        }

        public int get_client_installment_count(string sql_query="") {
            int client_installment_count = 0;
            string message_type = "get clients installment count from client_installments table";
            string logger_message_type = "get_client_installment_count";
            if(sql_query == "")
            {
                sql_query = "SELECT COUNT(*) FROM client_isntallment";
            }
            client_installment_count = new Database_data().get_one_data_query(sql_query, message_type, logger_message_type);
            return client_installment_count;
        }

    
    }
}
