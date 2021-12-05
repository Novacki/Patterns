using Adapter.Settings.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    interface IPaidMarketPaymentService
    {
        Token AuthToken();
        void Payment();
        void Receive();
    }
}
