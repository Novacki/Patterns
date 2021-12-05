using Adapter.Interfaces;
using Adapter.Settings.Auth;
using System;


namespace Adapter.Adapters
{
    class PaidMarketAdapter : IPayPalPaymentService
    {
        private IPaidMarketPaymentService paidMarket;

        public PaidMarketAdapter(IPaidMarketPaymentService paidMarket) 
        { 
            this.paidMarket = paidMarket;
            Console.WriteLine("Realizando Adaptação de Mercado Pago para os métodos do PayPal");
        }
        public Token AuthToken()
        {
            return this.paidMarket.AuthToken();
        }

        public void PayPalPayment()
        {
            this.paidMarket.Payment();
        }

        public void PayPalReceive()
        {
            this.paidMarket.Receive();
        }
    }
}
