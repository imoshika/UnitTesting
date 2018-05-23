using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    public interface IDataSource
    {
         Product GetProduct(Guid id);
    }
}
