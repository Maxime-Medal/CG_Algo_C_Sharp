namespace CodinGame_WA
{
    public class GetSuperCustomerBase
    {
        public IEnumerable<string> GetSuperCustomers(List<Order> orders)
        {
            var res = orders.GroupBy(o => o.Customer)
                            .Where(g => g.Sum(o => o.Price) > 100)
                            .Select(c => c.Key);
            return res;

        }
    }
}