using System.Threading.Tasks;
using Fluxor;
using FluxorGap.Data;

namespace FluxorGap.Store.EditCustomer
{
    public class Effects
    {
        public Effects(CustomerService customerService)
        {
            CustomerService = customerService;
        }

        private CustomerService CustomerService { get; }

        [EffectMethod]
        public async Task HandleAsync(GetCustomerAction action, IDispatcher dispatcher)
        {
            var customer = await CustomerService.GetCustomer(action.Id);
            dispatcher.Dispatch(new ReceiveCustomerAction(customer));
        }
    }
}
