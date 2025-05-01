using ParkingLotManagementSystem.Domain.Models;
using ParkingLotManagementSystem.Strategies.Fee_Calculation;
using ParkingLotManagementSystem.Strategies.PaymentStrategy;

namespace ParkingLotManagementSystem.Services
{
    public class PaymentService
    {
        private readonly FeeCalculationStrategyFactory _feeCalculationStrategyFactory;
        private readonly PaymentProcessorFactory _payementProcessorFactory;

        public PaymentService(FeeCalculationStrategyFactory feeCalculationStrategyFactory, PaymentProcessorFactory payementProcessorFactory)
        {
            _feeCalculationStrategyFactory = feeCalculationStrategyFactory;
            _payementProcessorFactory = payementProcessorFactory;
        }

        public Invoice GenerateInvoice(Ticket ticket, DateTime exitTime, PaymentMode paymentMode)
        {
            var pricingStrategy = _feeCalculationStrategyFactory.GetFeeCalculationStrategy(ticket.VechileType);
            var amount = pricingStrategy.CalculateFee(ticket.EntryTime, exitTime);
            var invoice = new Invoice
            {
                TicketId = ticket.TicketId,
                Amount = amount,
                //PaymentStatus = paymentStatus,
                ExitTime = exitTime
            };
            var paymentProcessor = _payementProcessorFactory.GetPaymentProcessor(paymentMode);
            var paymentStatus = paymentProcessor.ProcessPayment(invoice);
            return invoice;
        }
    }
}
