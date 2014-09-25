namespace Rain.BDDDojo.ParkingCost.Calculators
{
    class ValetParkingCalculator : IParkingCostCalculator
    {
        private const int ParkingCostIn5Hours = 12;
        private const int ParkingCostPerDay   = 18;
        private const int MinutesPerDay       = 3600;

        public double CalculateCost(int minutes)
        {
            if (minutes <= MinuteConvertor.Hours(5))
            {
                return ParkingCostIn5Hours;
            }
            return ParkingDays(minutes) * ParkingCostPerDay;
        }

        private int ParkingDays(int minutes)
        {
            return minutes / MinutesPerDay + ((minutes % MinutesPerDay != 0) ? 1 : 0);
        }
    }
}
