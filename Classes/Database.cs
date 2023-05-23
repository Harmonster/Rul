using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rul
{
    public static class Database
    {
        //public static string UserSurname { get; set; }
        //public static string UserName { get; set; }
        //public static string UserPatronymic { get; set; }
        //public static int UserRole { get; set; }
        //public static int UserId { get; set; }

        public static bool UserAuthorization(TextBox TbLogin, TextBox TbPassword)
        {
            if (string.IsNullOrEmpty(TbLogin.Text))
            {
                MessageBox.Show("Вы не ввели логин. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Вы не ввели пароль. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                using (MySqlConnection Сonnection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("UserAuthorization", Сonnection);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        cmd.Parameters.AddWithValue("u_login", TbLogin.Text);
                        cmd.Parameters.AddWithValue("u_password", TbPassword.Text);
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Пользователь с такими данными не найден. Перепроверьте данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            User.UserSurname = dt.Rows[0]["Фамилия"].ToString();
                            User.UserName = dt.Rows[0]["Имя"].ToString();
                            User.UserPatronymic = dt.Rows[0]["Отчество"].ToString();
                            User.UserRole = Convert.ToInt32(dt.Rows[0]["Роль"]);
                            User.UserId = Convert.ToInt32(dt.Rows[0]["Идентификатор"]);
                            return true;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        cmd.Dispose();
                        Сonnection.Close();
                    }
                }
            }
        }

        public static void GetProducts(DataTable dt)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetProductsList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }
    }
}
