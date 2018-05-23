using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=unitTestingDB;User ID=sa;Password=***********;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();

            SqlCommand comd = new SqlCommand("select * from dbo.Products");
            SqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Quantity"]);
                Console.ReadLine();
            }
            reader.Close();
            connection.Close();*/
        }
    }
}
