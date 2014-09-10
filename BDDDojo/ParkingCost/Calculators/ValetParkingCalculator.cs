namespace Rain.BDDDojo.ParkingCost.Calculators
{
    class ValetParkingCalculator : IParkingCostCalculator
    {
        public double CalculateCost(int minutes)
        {
            if (minutes <= MinuteConvertor.Hours(5))
            {
                return 12;
            }
            return 0;
        }
    }
}
