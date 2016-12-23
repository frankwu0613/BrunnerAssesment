using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderLibrary;

namespace Brunner.Test
{
    [TestClass]
    public class PricingTest
    {

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestGetTotalValue_NullObject_NullReferenceExceptionExpected()
        {
            //arrange
            Order order = null;
            
            //act
            decimal actual = Pricing.GetTotalValue(order);

            //assert is handled by ExpectedException

        }

        [TestMethod]
        public void TestGetTotalValue_NormalObjectWithDiscount_PriceMatch()
        {
            //arrage
            Order order = new Order(true, 3, 3);
            decimal expected = 2.2m;

            //act
            decimal actual = Pricing.GetTotalValue(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetTotalValue_NormalObjectWithoutDiscount_PriceMatch()
        {
            //arrage
            Order order = new Order(false, 10, 10);
            decimal expected = 11.0m;

            //act
            decimal actual = Pricing.GetTotalValue(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
