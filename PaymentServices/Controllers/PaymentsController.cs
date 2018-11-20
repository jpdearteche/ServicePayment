using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PaymentBusiness.DTO;
using PaymentBusiness.Rabbit;

namespace PaymentServices.Controllers
{
    public class PaymentsController : ApiController
    {
        //GET: api/Payments
        public IEnumerable<PaymentDTO> GetPayment()
        {
            return new PaymentBusiness.Implements.PaymentBusiness().GetAll();
        }

        //GET: api/payments/search/1
        [HttpGet]
        public IEnumerable<PaymentDTO> Search(string orderNumber)
        {
            return new PaymentBusiness.Implements.PaymentBusiness().GetAllPaymentsByIdOrder(orderNumber);
        }

        // POST: api/Payments/PostPayment
        [HttpPost]
        public async Task<IHttpActionResult> PostPayment(PaymentDTO payment)
        {
            try
            {
                var pay = await new PaymentBusiness.Implements.PaymentBusiness().SaveAsync(payment);
				new RabbitSender().Send($"El pago fué asociado a la orden Nº {payment.OrderNumber} con éxito", "payment-create");
				return Ok(pay);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> CancelPayment(int idPayment)
        {
            try
            {
                var paymentCancel = await new PaymentBusiness.Implements.PaymentBusiness().CancelPaymentAsync(idPayment);
				new RabbitSender().Send($"El pago asociado a la orden Nº {paymentCancel.OrderNumber} fué cancelado con éxito", "payment-cancel");
				return Ok(paymentCancel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }
    }
}