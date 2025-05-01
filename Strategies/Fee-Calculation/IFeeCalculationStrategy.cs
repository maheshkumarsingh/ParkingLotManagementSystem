namespace ParkingLotManagementSystem.Strategies.Fee_Calculation
{
    public interface IFeeCalculationStrategy
    {
        double CalculateFee(DateTime entryTime, DateTime exitTime);
    }
}
