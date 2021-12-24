using System;
using Solid.Lsp.Payments;

namespace Solid.Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var card = new DebitCard();
            var card = new NubankRewards();
            
            card.Validate();
            card.CollectPayment();
        }
    }
}
