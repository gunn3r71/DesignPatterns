using System;
using System.Threading;

namespace Solid.Lsp.Payments
{
    public class NubankRewards : IPaymentInstrument
    {
        public void Validate()
        {
            Console.WriteLine("Validation...");
            Thread.Sleep(1000);
            Console.WriteLine("Limit validation");
            Thread.Sleep(2000);
            Console.WriteLine("OK");
        }

        public void CollectPayment()
        {
            Console.WriteLine("Success on payment");
            Console.WriteLine("credited score");
        }
    }
}