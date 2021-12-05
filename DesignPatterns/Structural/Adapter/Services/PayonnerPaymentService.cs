using Adapter.Interfaces;
using Adapter.Settings.Auth;
using System;


namespace Adapter.Services
{
    class PayonnerPaymentService : IPayonnerPaymentService
    {

        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Payonner.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Payonner.");
        }

    }
}
