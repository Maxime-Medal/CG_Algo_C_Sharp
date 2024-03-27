using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
        public class Order
        {
            public string Customer { get; set; }
            public decimal Price { get; set; }
        }

    public class GetSuperCustomer
    {
        public IEnumerable<string> GetSuperCustomers(List<Order> orders)
        {
            var res = orders.GroupBy(o => o.Customer)
                            .Where(g => g.Sum(o => o.Price) >= 100)
                            .Select(c => c.Key);
            return res;

        }
    }
}
