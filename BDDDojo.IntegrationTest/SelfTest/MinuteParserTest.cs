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
    }
}
