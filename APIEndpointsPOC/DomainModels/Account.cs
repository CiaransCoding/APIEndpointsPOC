using APIEndpointsPOC.Enums;

namespace APIEndpointsPOC.DomainModels
{
    public class Account : BaseEntity
    {
        public List<Customer>? Customers { get; set; }
        public AccountTypes? AccountType { get; set; }
    }
}
