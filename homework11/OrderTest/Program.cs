using System;
using homework11;
using NUnit.Framework;

namespace OrderTest
{ 
    [TestFixture]
    class OrderTest
    {
        [Test]
        public void ConstructorTest()
        {
            var soap = CreateTestOrder();

            Assert.AreEqual("Soap", soap.ProductName);
            Assert.AreEqual(14042003, soap.VendorCode);
            Assert.AreEqual("Ivanov", soap.СourierSurname);
            Assert.AreEqual(67, soap.RequestNumber);
            Assert.AreEqual("14.06.2022", soap.DeliveryTime);
            Assert.AreEqual(DType.Express, soap.OrderType);
    }
        [Test]
        public void ToString_Order_ProductNameSpaceCourierSurname()
        {
            var soap = CreateTestOrder();

            Assert.AreEqual("Soap Ivanov", soap.ToString());
        }
        private Order CreateTestOrder()
        {
            return new Order ("Soap", 14042003, "Ivanov", 67, "14.06.2022", DType.Express);
        }
    }
}
