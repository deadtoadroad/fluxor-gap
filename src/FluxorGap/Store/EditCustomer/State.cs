using FluxorGap.Data;

namespace FluxorGap.Store.EditCustomer
{
    public class State
    {
        public State(bool isLoading, Customer customer)
        {
            IsLoading = isLoading;
            Customer = customer;
        }

        public bool IsLoading { get; }
        public Customer Customer { get; }
    }
}
