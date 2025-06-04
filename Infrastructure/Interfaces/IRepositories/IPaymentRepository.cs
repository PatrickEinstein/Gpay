using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gpay.Core.Models.Entities;
using Gpay.Models;

namespace Gpay.Infrastructure.Interfaces.IRepositories
{
    public interface IPaymentRepository
    {
        Task<bool> CreatePayment(PaymentTransactions paymentTransactions);
        Task<PaymentTransactions> GetPaymentByPaymentReference(string parameter);
        Task<PaymentTransactions> GetPaymentByAdviceReference(string parameter);
        Task<PaymentTransactions> GetPaymentByMerchantference(string parameter);
        Task<bool> UpdatePayment(PaymentTransactions paymentTransactions);
       
    }
}