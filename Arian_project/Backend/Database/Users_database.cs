using Arian_project.backend;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Arian_project.Backend.Database
{
    public class Users_database
    {
        private log logger = new log();
        Database_data database = new Database_data();
        public DataTable get_users_datatable(string sql_query = "")
        {
            string logger_message_type = "get_users_datatable";
            logger.record_log("get userss datatable from users table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM users";
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
        private int get_ac_log_id()
        {
            string sql_query = "SELECT MAX(id) FROM user_log";
            var connection = new Database_data().connection_to_db();
            connection.Open();
            int counts = 0;
            var command = new SQLiteCommand(sql_query, connection);

            object count = command.ExecuteScalar();

            if (count != null && count.ToString() != "")
            {
                counts = Convert.ToInt32(count.ToString());
            }
            connection.Close();
            return counts+1;
        } 
    
        public bool save_user_log(string username,string part,string job)
        {
            bool result = false;
            int id = get_ac_log_id();
            int[] date_ = new Iran_date().Today();
            string date = date_[0].ToString() + "" + date_[1].ToString() + "" + date_[2].ToString();
            string sql_query = $"INSERT INTO user_log(id,username,part,job,date)VALUES('{id}','{username}','{part}','{job}','{date}')";

            var connection = new Database_data().connection_to_db();
            connection.Open();
            using (var command = new SQLiteCommand(sql_query, connection))
            {
                result = command.ExecuteNonQuery() > 0;
            }
            connection.Close();
            return result;
        }
        public DataTable get_user_log_datatable(string sql_query = "")
        {
            string logger_message_type = "get_user_log_datatable";
            logger.record_log("get user_logs datatable from user_log table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM user_log";
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

        public List<Admin> get_users_list(string sql_query="") {
            string logger_message_type = "get_users_list";
            logger.record_log("get user list from users table", logger_message_type);
            if (sql_query == "")
            {
                sql_query = "SELECT * FROM users";
            }
            var users = new List<Admin>();
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
                                users.Add(new Admin(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3)));
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
            return users;

        }

        public int get_last_admin_id()
        {
            int id = 0;
            string message_type = "get_last_admin_id";
            string logger_message_type = "get last user id from users table";
            string sql_query = $"SELECT MAX(id) FROM users";
            try
            {
                id = database.run_one_item_data_query(sql_query, message_type, logger_message_type);
            }
            catch { }

            return id;
        }
        public bool insert_user_in_database(Admin user)
        {
            string logger_message_type = "insert_user_in_database";
            string message_type = "insert new user to users table";
            bool result = false;
            if (user.id != 0)
            {
                string sql_query = $"INSERT INTO users(id,username,password,access)VALUES('{user.id}','{user.username}','{user.password}','{user.access}')";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;
        }

        public bool edite_user_in_database(Admin user)
        {
            string logger_message_type = "edite_user_in_database";
            string message_type = "edite user in users table";
            bool result = false;
            if (user.id != 0)
            {
                string sql_query = $"UPDATE users SET username='{user.username}',password='{user.password}',access='{user.access}' WHERE id='{user.id}'";
                result = database.run_sql_query(sql_query, message_type, logger_message_type);
            }
            return result;

        }
        public bool delete_user_from_database(int id)
        {
            bool result = false;
            string message_type = "delete_user_from_database";
            string logger_message_type = "deete user from users table";
            string sql_query = $"DELETE * FROM users WHERE id='{id}'";
            result = database.run_sql_query(sql_query,message_type,logger_message_type);
            return result;
        }

        public bool admin_login(string username, string password) { 
            bool result = false;
            string message_type = "admin_login";
            string logger_message_type = $"admin => {username} with password => {password} try to login";
            string sql_query = $"SELECT COUNT(*) FROM users WHERE username='{username}' AND password='{password}'";
            result = database.run_one_item_data_query(sql_query,message_type,logger_message_type)>0;
            return result;
        }
        public Admin get_admin_data(string username,string password)
        {
            string logger_message_type = "get_admin_data";
            string message_type = "get admin data from users table";
            Admin user= Admin.Empty();
            string sql_query = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'";
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
                                user = new Admin(
                                        adapter.GetInt32(0),
                                        adapter.GetString(1),
                                        adapter.GetString(2),
                                        adapter.GetString(3)
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
            return user;
        }
        public int get_users_count()
        {
            int count = 0;
            string message_type = "get_users_count";
            string logger_message_Type = "get users count from users table";
            string sql_query = $"SELECT COUNT(*) FROM users";
            count = database.run_one_item_data_query(sql_query, message_type, logger_message_Type);
            return count;
        }
        
        public void Set_Admin(Admin admin)
        {
            Properties.Settings.Default.username = admin.username;
            Properties.Settings.Default.access = admin.access;
            Properties.Settings.Default.Save();
        }

        public void Unset_Admin()
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.access = "";
            Properties.Settings.Default.Save();
        }

        public Admin Get_Admin()
        {
            Admin admin = Admin.Empty();
            admin.username = Properties.Settings.Default.username;
            admin.access = Properties.Settings.Default.access;
            return admin;
        }

    }
}
