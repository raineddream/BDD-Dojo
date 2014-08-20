using System;
using TechTalk.SpecFlow;

namespace Rain.BDDDojo.IntegrationTest.Features
{
    [Binding]
    public class ValetParkingSteps
    {
        [When(@"I park my car in the Valet Parking Lot for (.*) minutes")]
        public void When_I_par_my_car_in_the_valet_parking_lot_for_minutes(int minutes)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I will have to pay \$(.*)")]
        public void ThenIWillHaveToPay(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
