using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1704
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command and Data Reader
            using (SqlConnection conn = new SqlConnection(@"Data Source=VS17-SQL2017\SQLEXPRESS;Initial Catalog=1404;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT_ALL_STUDENTS", conn);

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

                while (reader.Read() == true)
                {
                    Console.WriteLine($" {reader["ID"]} {reader["NAME"]} {reader["COUNTRY_ID"]}");
                }

                cmd.Connection.Close();
            }
        }
    }
}
