namespace ProjectCollege.Service
{
    public class PaypalPaymentService : PaymentInterface
    {
        private string Email { get; set; }
        private string Password { get; set; }

        public PaypalPaymentService(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool Pay(int total)
        {
            return true;
        }
    }
}
