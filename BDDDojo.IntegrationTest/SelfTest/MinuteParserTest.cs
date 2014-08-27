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
            Assert.That(MinuteParser.Parse("10 minutes"), Is.EqualTo(10));
        }

        [Test]
        public void Should_parse_minutes_even_no_space_between_number_and_unit()
        {
            Assert.That(MinuteParser.Parse("10minutes"), Is.EqualTo(10));
        }

        [Test]
        public void Should_parse_ONE_minute()
        {
            Assert.That(MinuteParser.Parse("1 minute"), Is.EqualTo(1));
        }

        [Test]
        public void Should_only_parse_hours()
        {
            Assert.That(MinuteParser.Parse("2 hours"), Is.EqualTo(120));
        }

        [Test]
        public void Should_parse_hours_even_no_space_between_number_and_unit()
        {
            Assert.That(MinuteParser.Parse("2hours"), Is.EqualTo(120));
        }

        [Test]
        public void Should_parse_ONE_hour()
        {
            Assert.That(MinuteParser.Parse("1 hour"), Is.EqualTo(60));
        }

        [Test]
        public void Should_parse_hours_and_minutes()
        {
            Assert.That(MinuteParser.Parse("2 hours and 2 minutes"), Is.EqualTo(122));
        }
    }
}
