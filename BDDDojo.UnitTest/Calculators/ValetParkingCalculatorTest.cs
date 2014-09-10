using NUnit.Framework;
using Rain.BDDDojo.ParkingCost;
using Rain.BDDDojo.ParkingCost.Calculators;

namespace Rain.BDDDojo.UnitTest.Calculators
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
            Assert.That(_costCalculator.CalculateCost(MinuteConvertor.Hours(5)), Is.EqualTo(12));
        }

        [Test]
        public void Should_charge_18_dollars_when_valet_parking_time_is_slightly_more_than_5_hours()
        {
            Assert.That(_costCalculator.CalculateCost(MinuteConvertor.HoursAndMinutes(5, 1)), Is.EqualTo(18));
        }

        [Test]
        public void Should_charge_18_dollars_when_valet_parking_time_is_1_day()
        {
            Assert.That(_costCalculator.CalculateCost(MinuteConvertor.Days(1)), Is.EqualTo(18));
        }
    }
}
