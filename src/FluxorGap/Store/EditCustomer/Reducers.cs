using Fluxor;

namespace FluxorGap.Store.EditCustomer
{
    public static class Reducers
    {
        [ReducerMethod]
        public static State Reduce(State state, GetCustomerAction action)
        {
            return new State(true, null);
        }

        [ReducerMethod]
        public static State Reduce(State state, ReceiveCustomerAction action)
        {
            return new State(false, action.Customer);
        }
    }
}
