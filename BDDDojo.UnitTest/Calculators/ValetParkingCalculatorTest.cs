using NUnit.Framework;
using Rain.BDDDojo.ParkingCost;
using Rain.BDDDojo.ParkingCost.Calculators;

namespace BDDDojo.UnitTest.Calculators
{
    [TestFixture]
    public class ValetParkingCalculatorTest
    {
        private IParkingCostCalculator _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = CalculatorFactory.CreateCalculator(ParkingType.ValetParking);
        }

        [Test]
        public void Should_charge_12_dollars_when_valet_parking_time_is_less_than_5_hours()
        {
            Assert.That(_costCalculator.CalculateCost(30), Is.EqualTo(12));
        }
    }
}
