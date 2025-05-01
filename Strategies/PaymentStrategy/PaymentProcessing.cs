using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Strategies.PaymentStrategy
{
    public interface IPaymentProcessor
    {
        bool ProcessPayment(Invoice invoice);
    }
    public class CashPaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(Invoice invoice)
        {
            Console.WriteLine($"Cash payment of ₹{invoice.Amount} received.");
            return true;
        }
    }

    public class OnlinePaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(Invoice invoice)
        {
            Console.WriteLine($"Online payment of ₹{invoice.Amount} processed.");
            return true;
        }
    }
    public enum PaymentMode
    {
        Cash,
        Online
    }

    public class PaymentProcessorFactory
    {
        public IPaymentProcessor GetPaymentProcessor(PaymentMode mode)
        {
            return mode switch
            {
                PaymentMode.Cash => new CashPaymentProcessor(),
                PaymentMode.Online => new OnlinePaymentProcessor(),
                _ => throw new NotSupportedException("Unsupported payment mode")
            };
        }
    }
}
