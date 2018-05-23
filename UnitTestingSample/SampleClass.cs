using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UnitTestingSample
{
    public class SampleClass
    {

        public readonly IDataSource _datasource;

        public SampleClass(IDataSource source)
        {
            _datasource = source;
        }
        //private readonly MyDataSource dataSource;
        //SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=unitTestingDB;User ID=sa;Password=***********;Integrated Security=True;MultipleActiveResultSets=True");

        public bool checkQty(Guid id)
        {
            var pro = _datasource.GetProduct(id);
            return pro.quantity <= 5;
        }


    }
}
