using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Services;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
      
            IPayPalPaymentService payment = new PayonnerAdapter(new PayonnerPaymentService());
            payment.PayPalPayment();
            payment.PayPalReceive();

            payment  = new PaidMarketAdapter(new PaidMarketPaymentService());
            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
