namespace Solid.Lsp.Payments
{
    public interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}