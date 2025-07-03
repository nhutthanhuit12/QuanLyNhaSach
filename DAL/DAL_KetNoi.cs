using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace QuanLyNhaSach.DAL
{
    public class DAL_KetNoi
    {
        private string connectionStr = @"Data Source=DESKTOP-JK8JM6M;Initial Catalog=QuanLyNhaSach;Integrated Security=True;Encrypt=False";

        private static DAL_KetNoi instance;

        public static DAL_KetNoi Instance {
            get { if (instance == null) instance = new DAL_KetNoi(); return instance; }
            private set => instance = value; 
        }

        private DAL_KetNoi() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;

        }

        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using(SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data > 0;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using(SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
                return data;
            }
        }
    }
}
