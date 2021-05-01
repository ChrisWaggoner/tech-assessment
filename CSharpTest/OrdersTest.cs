using NUnit.Framework;
using System.Collections.Generic;

namespace OrdersTest
{
    public class OrdersTest
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void OrdersGetReturnsAtLeastTwoOrders()
        { 
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            string[] result = (string[])ordersTest.Get();
            Assert.That(result.Length, Is.AtLeast(2));
        }

        [Test]
        public void GetOrdersByCustomerReturnsAtLeastTwoOrders()
        {
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            string[] result = (string[])ordersTest.GetOrdersForCustomer(3);
            Assert.That(result.Length, Is.AtLeast(2));
        }

        [Test]
        public void OrdersGetByIDReturnsSingleOrderForAnyOrderID()
        {
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            string result = ordersTest.Get(3);
            Assert.That(result, Is.EqualTo("Single Order"));
        }

        [Test]
        public void OrderPostAcceptsAStringWithoutError()
        {
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            ordersTest.Post("test");
            Assert.True(true);
        }

        [Test]
        public void OrderPutAcceptsAnIDAndStringWithoutError()
        {
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            ordersTest.Put(3, "test");
            Assert.True(true);
        }

        [Test]
        public void OrderDeleteAcceptsAnIDWithoutError()
        {
            CSharp.Controllers.OrdersController ordersTest = new CSharp.Controllers.OrdersController();
            ordersTest.Delete(3);
            Assert.True(true);
        }
    }
}