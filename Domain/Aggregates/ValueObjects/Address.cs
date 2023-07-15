namespace Domain.Aggregates.ValueObjects
{
    public class Address
    {
        public string City { get; }
        public string Road { get; }

        public Address(string city, string road)
        {
            City = city;
            Road = road;
        }
    }
}
