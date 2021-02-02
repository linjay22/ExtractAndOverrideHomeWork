using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtractAndOverrideTest;

namespace ExtractAndOverride
{
    public class ExtendOrderService : OrderService
    {
        public List<Order> _orders;

        protected override IEnumerable<Order> GetOrders()
        {
            return _orders;
        }

        public void SetOrders(List<Order> order)
        {
            _orders = order;
        }
    }
}
