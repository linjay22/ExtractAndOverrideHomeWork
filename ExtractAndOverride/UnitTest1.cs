using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExtractAndOverrideTest;

namespace ExtractAndOverride
{
    [TestClass]
    public class UnitTest1
    {
        private ExtendOrderService _svc;
        public List<Order> _actual;
        public IDictionary<string, int> _expected;

        [TestInitialize]
        public void SetUp()
        {
            _svc = new ExtendOrderService();
            _actual = new List<Order>();
            _expected = new Dictionary<string, int>();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestType1()
        {
            _actual.Add(new Order() { Type = "Book", ProductName = "PA", Price = 100, CustomerName = "CA" });
            _actual.Add(new Order() { Type = "Book", ProductName = "PA", Price = 200, CustomerName = "CB" });
            _actual.Add(new Order() { Type = "Book", ProductName = "PA", Price = 300, CustomerName = "CC" });

            _expected.Add("PA", 600);

            _svc.SetOrders(_actual);

            Assert.AreEqual(_svc.GetTopBooksByOrders(), _expected);
        }
    }
}
