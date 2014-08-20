namespace Rain.BDDDojo.ParkingCost
{
    public class ParkingCostCalculatorPresenter
    {
        private readonly IParkingCostCalculatorView _view;

        public ParkingCostCalculatorPresenter(IParkingCostCalculatorView view)
        {
            _view = view;
        }

        public double CalculateCost(ParkingType parkingType, int minutes)
        {
            if (parkingType == ParkingType.ValetParking)
            {
                if (minutes <= 300)
                {
                    return 12;
                }
            }

            return 0;
        }
    }
}