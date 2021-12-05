using Adapter.Services;
using Adapter.Settings.Auth;

namespace Adapter.Interfaces
{
    interface IPayonnerPaymentService
    {

        Token AuthToken();
        void SendPayment();
        void ReceivePayment();

    }
}
