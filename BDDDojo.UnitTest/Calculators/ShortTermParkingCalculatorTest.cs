using NUnit.Framework;
using Rain.BDDDojo.ParkingCost;
using Rain.BDDDojo.ParkingCost.Calculators;

namespace Rain.BDDDojo.UnitTest.Calculators
{
    [TestFixture]
    public class ShortTermParkingCalculatorTest
    {
        private IParkingCostCalculator _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = CalculatorFactory.CreateCalculator(ParkingType.ShortTermParking);
        }

        [TestCase(30, 2.00)]
        [TestCase(60, 2.00)]
        public void Should_charge_2_dollars_when_park_less_than_1_hour_shortly(int minutes, double charge)
        {
            Assert.That(_costCalculator.CalculateCost(minutes), Is.EqualTo(charge));
        }
    }
}
