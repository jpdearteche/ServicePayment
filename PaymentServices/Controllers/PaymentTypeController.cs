using PaymentBusiness.DTO;
using PaymentBusiness.Implements;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PaymentServices.Controllers
{
    public class PaymentTypeController : ApiController
    {
        [HttpGet]
        public IEnumerable<PaymentTypeDTO> GetActivePaymentType()
        {
            return new PaymentTypeBusiness().GetAll();
        }

        [HttpPost]
        public IHttpActionResult ChangeActivePaymentType(int idPaymentType, bool isActive)
        {
            try
            {
                var paymentTypeDTO = new PaymentTypeBusiness().ChangeActivePaymentType(idPaymentType, isActive);
                return Ok(paymentTypeDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }
    }
}
