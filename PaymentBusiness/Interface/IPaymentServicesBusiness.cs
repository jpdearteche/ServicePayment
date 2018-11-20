using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusiness.Interface
{
    interface IPaymentServicesBusiness<T>
    {
        IEnumerable<T> GetAll();
        Task<T> SaveAsync(T obj);
        T GetById(int id);
    }
}
