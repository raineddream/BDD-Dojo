namespace Rain.BDDDojo.ParkingCost.Calculators
{
    class ShortTermParkingCalculator : IParkingCostCalculator
    {
        public double CalculateCost(int minutes)
        {
            return 2;
        }
    }
}