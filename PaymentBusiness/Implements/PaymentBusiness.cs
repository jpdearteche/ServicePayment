using PaymentBusiness.DTO;
using PaymentBusiness.Enumerations;
using PaymentBusiness.Interface;
using PaymentBusiness.Rabbit;
using PaymentDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentBusiness.Implements
{
    public class PaymentBusiness : IPaymentServicesBusiness<PaymentDTO>
    {
        public IEnumerable<PaymentDTO> GetAll()
        {
            using(var model = new PaymentServicesEntities())
            {
                return model.Payment.Select(x => new PaymentDTO()
                {
                    PaymentNum = x.PaymentNumber,
                    ClientCode = x.ClientCode,
                    TotalPayment = x.TotalPayment,
                    PaymentDate = x.PaymentDate,
                    StatusCode = x.Status.Code,
                    StatusName = x.Status.Name,
                    CodePaymentType = x.PaymentType.Code,
                    NamePaymentType = x.PaymentType.Name,
                    OrderNumber = x.OrderNumber
                }).ToList();
            }
        }

        public IEnumerable<PaymentDTO> GetAllPaymentsByIdOrder(string orderNumber)
        {
            using (var model = new PaymentServicesEntities())
            {
                return model.Payment.Where(x => x.OrderNumber == orderNumber).Select(x => new PaymentDTO
                {
                    PaymentNum = x.PaymentNumber,
                    ClientCode = x.ClientCode,
                    TotalPayment = x.TotalPayment,
                    NamePaymentType = x.PaymentType.Name,
                    StatusName = x.Status.Name,
                    PaymentDate = x.PaymentDate
                }).ToArray();
            }
        }

        public async Task<PaymentDTO> SaveAsync(PaymentDTO paymentDTO)
        {
            using (var model = new PaymentServicesEntities())
            {
                int number = 0;
                var paymentType = model.PaymentType.FirstOrDefault(x => x.Code == paymentDTO.CodePaymentType);
                var lastPayment = model.Payment.OrderByDescending(x => x.IdPayment).FirstOrDefault();
                if (lastPayment != null)
                    int.TryParse(lastPayment.PaymentNumber, out number);
                var payment = new Payment()
                {
                    OrderNumber = paymentDTO.OrderNumber,
                    ClientCode = paymentDTO.ClientCode,
                    TotalPayment = paymentDTO.TotalPayment,
                    PaymentNumber = (++number).ToString(),
                    PaymentDate = DateTime.Now
                };
                payment.IdStatus = (int)ePaymentStatus.Created;
                payment.PaymentType = paymentType ?? throw new Exception("Payment Type Code is not Valid");
                model.Payment.AddObject(payment);
                var result = model.SaveChanges();
				if (result > 0)
				{
					paymentDTO.PaymentNum = payment.PaymentNumber;
					paymentDTO.StatusCode = payment.Status.Code;
					paymentDTO.StatusName = payment.Status.Name;
					paymentDTO.NamePaymentType = payment.PaymentType.Name;
				}
					
                return paymentDTO;
            }
        }

        public async Task<PaymentDTO> CancelPaymentAsync(int idPayment)
        {
            using(var model = new PaymentServicesEntities())
            {
                var payment = model.Payment.FirstOrDefault(x => x.IdPayment == idPayment);
                if (payment == null)
                    throw new Exception("Payment not found");
                payment.IdStatus = (int)ePaymentStatus.Cancel;
                model.Payment.ApplyCurrentValues(payment);
                model.SaveChanges();
                return new PaymentDTO()
                {
                    PaymentNum = payment.PaymentNumber,
                    PaymentDate = payment.PaymentDate,
                    StatusName = payment.Status.Name
                };
            }
        }

        public PaymentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
