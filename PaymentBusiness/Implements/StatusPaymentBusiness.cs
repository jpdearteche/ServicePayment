using PaymentBusiness.DTO;
using PaymentBusiness.Interface;
using PaymentDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusiness.Implements
{
    public class StatusPaymentBusiness : IPaymentServicesBusiness<StatusPaymentDTO>
    {
        public IEnumerable<StatusPaymentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public StatusPaymentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public StatusPaymentDTO GetStatusPayment(int idPayment)
        {
            using (var model = new PaymentServicesEntities())
            {
                var payment = model.Payment.FirstOrDefault(x => x.IdPayment == idPayment);
                if (payment == null)
                    new Exception("Payment not found");
                return new StatusPaymentDTO()
                {
                    IdPayment = payment.IdPayment,
                    Name = payment.Status.Name
                };
            }
        }

        public Task<StatusPaymentDTO> SaveAsync(StatusPaymentDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
