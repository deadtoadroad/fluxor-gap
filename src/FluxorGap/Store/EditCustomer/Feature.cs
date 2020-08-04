using Fluxor;

namespace FluxorGap.Store.EditCustomer
{
    public class Feature : Feature<State>
    {
        public override string GetName()
        {
            return nameof(EditCustomer);
        }

        protected override State GetInitialState()
        {
            return new State(false, null);
        }
    }
}
