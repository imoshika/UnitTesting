using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    public class SampleProductTesting : IDataSource
    {

        public virtual Product GetProduct(Guid id)
        {
            var p = new SqlParameter("@ProductID", DbType.Guid) { Value = id };

            using (var con = new SqlConnection("Data Source=localhost;Initial Catalog=unitTestingDB;User ID=sa;Password=***********;Integrated Security=True;MultipleActiveResultSets=True"))
            {
                string str = "select * from Products";
                using (var comd = new SqlCommand(str, con))
                {
                    comd.Parameters.Add(p);

                    con.Open();
                    using (var reader = comd.ExecuteReader())
                    {
                        Product data = null;
                        if (reader.Read())
                        {
                            data = new Product((int)reader["Quantity"]);
                        }

                        return data;
                    }
                }
            }
        }
    }
}
