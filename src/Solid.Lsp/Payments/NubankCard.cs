using System;

namespace Solid.Lsp.Payments
{
    public abstract class NubankCard : IPaymentInstrument
    {
        public abstract void Validate();

        public void CollectPayment()
        {
            Console.WriteLine("Success on payment");
        }
    }
}