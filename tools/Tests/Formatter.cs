using NUnit.Framework;

namespace CSharpMarkupTools.Tests
{
    public class Formatter
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectFormatRemainsIdentical()
        {
            string source = @"
";
            var formatter = new CSharpMarkupTools.Formatter(new CSharpMarkupTools.Formatter.Settings { FormatWhiteSpace = true, MaxLineLength = 80 });
            Assert.That(source, Is.EqualTo(formatter.Format(source)));
        }
    }
}