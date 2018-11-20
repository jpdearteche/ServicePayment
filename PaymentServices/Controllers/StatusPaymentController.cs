using PaymentBusiness.DTO;
using PaymentBusiness.Implements;
using System.Collections.Generic;
using System.Web.Http;

namespace PaymentServices.Controllers
{
    public class StatusPaymentController : ApiController
    {
        //GET: api/statuspayment/GetStatusPayment/1
        [HttpGet]
        public StatusPaymentDTO GetStatusPayment(int idPayment)
        {
            return new StatusPaymentBusiness().GetStatusPayment(idPayment);
        }

        [HttpGet]
        public IEnumerable<StatusPaymentDTO> GetAllStatusPayment()
        {
            return new StatusPaymentBusiness().GetAll();
        }
    }
}
