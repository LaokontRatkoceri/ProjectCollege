using Microsoft.AspNetCore.Mvc;
using Project;
using ProjectCollege.helper;
using ProjectCollege.Service;

namespace ProjectCollege.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymetController : ControllerBase
    {
        private readonly CollegeDbContext _context;

        public PaymetController(CollegeDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void PayController(PaymentDTO paymentDTO)
        {
            PaymentInterface paymentservice = null;

            if (paymentDTO.Type == "direct")
            {
                paymentservice = new CardPaymentService(paymentDTO.CardOwner, paymentDTO.CardCVV, paymentDTO.CardNumber);
            }
            else if(paymentDTO.Type == "paypal")
            {
                paymentservice = new PaypalPaymentService(paymentDTO.Email, paymentDTO.Password);
            }
            paymentservice.Pay(10);
        }
    }
}
