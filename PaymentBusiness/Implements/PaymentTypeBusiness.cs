using PaymentBusiness.DTO;
using PaymentBusiness.Interface;
using PaymentDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentBusiness.Implements
{
    public class PaymentTypeBusiness : IPaymentServicesBusiness<PaymentTypeDTO>
    {
        public IEnumerable<PaymentTypeDTO> GetAll()
        {
            using (var model = new PaymentServicesEntities())
            {
                return model.PaymentType.Where(y => y.IsActive).Select(x => new PaymentTypeDTO
                {
                     IsActive = x.IsActive,
                     Code = x.Code,
                     IdPaymentType = x.IdPaymentType,
                     Name = x.Name
                }).ToArray();
            }
        }

        public PaymentTypeDTO GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PaymentTypeDTO> SaveAsync(PaymentTypeDTO obj)
        {
            throw new System.NotImplementedException();
        }

        public PaymentTypeDTO ChangeActivePaymentType(int idPaymentType, bool isActive)
        {
            using (var model = new PaymentServicesEntities())
            {
                var paymentType = model.PaymentType.FirstOrDefault(x => x.IdPaymentType == idPaymentType);
                if (paymentType == null)
                    throw new Exception("Payment type not found");
                paymentType.IsActive = isActive;
                model.PaymentType.ApplyCurrentValues(paymentType);
                model.SaveChanges();
                return new PaymentTypeDTO
                {
                    IsActive = paymentType.IsActive,
                    Code = paymentType.Code,
                    IdPaymentType = paymentType.IdPaymentType,
                    Name = paymentType.Name
                };
            }
        }
    }
}

