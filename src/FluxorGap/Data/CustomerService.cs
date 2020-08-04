using System.Threading.Tasks;

namespace FluxorGap.Data
{
    public class CustomerService
    {
        public async Task<Customer> GetCustomer(int _)
        {
            await Task.Delay(500);

            return new Customer {FirstName = "Joe", LastName = "Fox"};
        }
    }
}
