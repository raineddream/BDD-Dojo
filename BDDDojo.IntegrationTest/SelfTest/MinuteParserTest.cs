using NUnit.Framework;
using Rain.BDDDojo.IntegrationTest.Features;

namespace Rain.BDDDojo.IntegrationTest.SelfTest
{
    [TestFixture]
    public class MinuteParserTest
    {
        [Test]
        public void Should_only_parse_minutes()
        {
            int minutes = MinuteParser.Parse("10 minutes");

            Assert.That(minutes, Is.EqualTo(10));
        }

        [Test]
        public void Should_parse_minutes_even_no_space_between_number_and_unit()
        {
            int minutes = MinuteParser.Parse("10minutes");

            Assert.That(minutes, Is.EqualTo(10));
        }

        [Test]
        public void Should_parse_ONE_minute()
        {
            int minutes = MinuteParser.Parse("1 minute");

            Assert.That(minutes, Is.EqualTo(1));
        }
    }
}
