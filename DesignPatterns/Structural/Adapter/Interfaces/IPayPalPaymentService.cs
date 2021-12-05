using Adapter.Services;
using Adapter.Settings.Auth;

namespace Adapter.Interfaces
{
    interface IPayPalPaymentService
    {

        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();

    }
}
