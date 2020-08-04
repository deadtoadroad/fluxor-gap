using FluxorGap.Data;

namespace FluxorGap.Store.EditCustomer
{
    public class GetCustomerAction
    {
        public GetCustomerAction(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }

    public class ReceiveCustomerAction
    {
        public ReceiveCustomerAction(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; }
    }
}
