using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Strategies.Fee_Calculation
{
    public class FeeCalculationStrategyFactory
    {
        public IFeeCalculationStrategy GetFeeCalculationStrategy(VechileType type)
        {
            return type switch
            {
                VechileType.Small => new SmallVechileFeeCalculationStrategy(),
                VechileType.Medium => new MediumVechileFeeCalculationStrategy(),
                VechileType.Large => new LargeVechileFeeCalculationStrategy(),
                _ => throw new ArgumentException("Invalid fee calculation strategy type")
            };
        }
    }
}
