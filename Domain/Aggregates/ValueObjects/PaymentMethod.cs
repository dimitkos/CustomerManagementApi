namespace Domain.Aggregates.ValueObjects
{
    public class PaymentMethod
    {
        public CardType CardType { get; }
        public string BankName { get; }

        public PaymentMethod(CardType cardType, string bankName)
        {
            CardType = cardType;
            BankName = bankName;
        }
    }

    public enum CardType
    {
        Debit,
        Credit,
        Prepaid,
        Online
    }
}
