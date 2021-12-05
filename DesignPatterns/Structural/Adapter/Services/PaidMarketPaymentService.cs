using Adapter.Interfaces;
using Adapter.Settings.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    class PaidMarketPaymentService : IPaidMarketPaymentService
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void Payment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }

        public void Receive()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }
    }
}
