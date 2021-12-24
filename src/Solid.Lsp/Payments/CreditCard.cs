using System;
using System.Threading;

namespace Solid.Lsp.Payments
{
    public class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validation...");
            Thread.Sleep(1000);
            Console.WriteLine("Limit validation");
            Thread.Sleep(2000);
            Console.WriteLine("OK");
            Thread.Sleep(500);
        }
    }
}