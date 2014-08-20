using Rain.BDDDojo.ParkingCost.Calculators;

namespace Rain.BDDDojo.ParkingCost
{
    public class ParkingCostCalculatorPresenter
    {
        private readonly IParkingCostCalculatorView _view;

        public ParkingCostCalculatorPresenter(IParkingCostCalculatorView view)
        {
            _view = view;
        }

        public void CalculateCost(ParkingType parkingType, int minutes)
        {
            IParkingCostCalculator calculator = CalculatorFactory.CreateCalculator(parkingType);
            _view.GiveParkingCost(calculator.CalculateCost(minutes));
        }
    }
}