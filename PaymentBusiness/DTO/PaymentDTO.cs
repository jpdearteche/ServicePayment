using System;

namespace PaymentBusiness.DTO
{
    [Serializable]
    public class PaymentDTO
    {
        public string PaymentNum { get; set; }
        public string   ClientCode { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime PaymentDate { get; set; }
		public string PaymentDateShort
		{
			get => PaymentDate.ToShortDateString();
		}
		public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public string CodePaymentType { get; set; }
        public string NamePaymentType { get; set; }
        public string OrderNumber { get; set; }

    }
}