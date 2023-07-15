using Domain.Aggregates.ValueObjects;

namespace Domain.Aggregates.Customer
{
#warning should add a root entity
    public class Customer
    {
        private List<PaymentMethod> _paymentMethods;
        private List<Order> _orders;

        public int CustomerId { get; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();
        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();

        public Customer(int customerId, string username, string email, string phone, DateTime createdAt, DateTime updatedAt, Address address, List<PaymentMethod> paymentMethods, List<Order> orders)
        {
            _paymentMethods = paymentMethods;
            _orders = orders;
            CustomerId = customerId;
            Username = username;
            Email = email;
            Phone = phone;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Address = address;
        }
    }
}
