using NUnit.Framework;
using Rain.BDDDojo.ParkingCost.Calculators;

namespace Rain.BDDDojo.UnitTest.Calculators
{
    [TestFixture]
    public class MinuteConvertorTest
    {
        [Test]
        public void Should_convert_hours_to_minutes()
        {
            int minutes = MinuteConvertor.Hours(1);

            Assert.That(minutes, Is.EqualTo(60));
        }
    }
}
