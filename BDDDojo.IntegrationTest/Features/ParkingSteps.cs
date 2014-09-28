using Moq;
using Rain.BDDDojo.ParkingCost;
using TechTalk.SpecFlow;

namespace Rain.BDDDojo.IntegrationTest.Features
{
    [Binding]
    public class ParkingSteps
    {
        private Mock<IParkingCostCalculatorView> _mockedCalculator;
        private ParkingCostCalculatorPresenter _presenter;

        [BeforeScenario]
        public void SetupScenario()
        {
            _mockedCalculator = new Mock<IParkingCostCalculatorView>();
            _presenter = new ParkingCostCalculatorPresenter(_mockedCalculator.Object);
        }

        [When(@"I park my car in the Valet Parking Lot for (.*)")]
        public void When_I_par_my_car_in_the_valet_parking_lot_in(string duration)
        {
            _presenter.CalculateCost(ParkingType.ValetParking, MinuteParser.Parse(duration));
        }

        [When(@"I park my car in the Short-Term Parking Lot for (.*)")]
        public void When_I_park_my_car_in_the_short_term_parking_lot_in(string duration)
        {
            _presenter.CalculateCost(ParkingType.ShortTermParking, MinuteParser.Parse(duration));
        }


        [Then(@"I will have to pay \$(.*)")]
        public void Then_I_will_have_to_pay(double expectedCost)
        {
            _mockedCalculator.Verify(x => x.GiveParkingCost(expectedCost));
        }
    }
}
