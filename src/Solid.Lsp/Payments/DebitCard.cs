using System;
using System.Threading;

namespace Solid.Lsp.Payments
{
    public class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validating...");

            Thread.Sleep(1000);
            Console.WriteLine("Balance validation..");
            Thread.Sleep(2000);
            Console.WriteLine("OK");
            Thread.Sleep(500);
        }
    }
}