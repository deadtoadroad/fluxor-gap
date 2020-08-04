namespace FluxorGap.Data
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer Clone()
        {
            return new Customer {
                FirstName = FirstName,
                LastName = LastName
            };
        }
    }
}
