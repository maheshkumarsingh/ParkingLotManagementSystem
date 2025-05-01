
namespace ParkingLotManagementSystem.Strategies.Fee_Calculation
{
    public class SmallVechileFeeCalculationStrategy : IFeeCalculationStrategy
    {
        public double CalculateFee(DateTime entryTime, DateTime exitTime)
        {
            var totalHours = Math.Ceiling((exitTime - entryTime).TotalHours);
            if (totalHours <= 2)
                return 20;
            return 20 + (totalHours - 2) * 10;
        }
    }
}
