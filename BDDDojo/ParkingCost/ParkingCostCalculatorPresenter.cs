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
            throw new System.NotImplementedException();
        }
    }
}