namespace Rain.BDDDojo.ParkingCost.Calculators
{
    public class MinuteConvertor
    {
        private const int MinutesPerHour = 60;

        public static int Hours(int hours)
        {
            return hours * MinutesPerHour;
        }
    }
}