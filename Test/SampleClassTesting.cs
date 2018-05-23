using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using UnitTestingSample;

namespace Test
{
    public class SampleClassTesting
    {
        [Fact]
        public void TestingProductQty()
        {
            var datasource = new Mock<IDataSource>();
            var p = new Product(5);
            datasource
                .Setup(m => m.GetProduct(It.IsAny<Guid>()))
                .Returns(p);

            var testingclass = new SampleClass(datasource.Object);

            var checkingQty = testingclass.checkQty(Guid.NewGuid());
            Assert.True(checkingQty);
        }
    }
}
