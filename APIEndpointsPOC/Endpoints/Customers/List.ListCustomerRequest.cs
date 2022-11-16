namespace APIEndpointsPOC.Endpoints.Customers
{
    public class ListCustomerRequest
    {
        public int MaxResults { get; set; }
        public bool IncludeCeased { get; set; }
    }
}
