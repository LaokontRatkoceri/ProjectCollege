namespace ProjectCollege.Service
{
    public class CardPaymentService:PaymentInterface
    {
        private string cardOwner;
        private int cardCVV;
        private int cardNumber;

        public CardPaymentService(string cardOwner, int cardCVV, int cardNumber)
        {
            this.cardOwner = cardOwner;
            this.cardCVV = cardCVV;
            this.cardNumber = cardNumber;
        }

        public bool Pay(int total)
        {
            return true;
        }
    }
}
