using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusiness.DTO
{
    public class StatusPaymentDTO
    {
        public int IdPayment { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int IdStatus { get; set; }
    }
}
