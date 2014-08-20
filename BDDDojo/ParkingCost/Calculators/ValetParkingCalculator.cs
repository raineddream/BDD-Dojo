namespace Rain.BDDDojo.ParkingCost.Calculators
{
    class ValetParkingCalculator : IParkingCostCalculator
    {
        public double CalculateCost(int minutes)
        {
            if (minutes <= 300)
            {
                return 12;
            }
            return 0;
        }
    }
}
