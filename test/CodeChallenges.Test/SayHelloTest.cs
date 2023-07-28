
namespace CodeChallenges.Test
{
    [TestFixture]
    public class SayHelloTest
    {

        [TestCase(null, "Hello there!")]
        [TestCase("", "Hello there!")]
        [TestCase("Lucas", "Hello, Lucas!")]
        [TestCase(" multiple words with space ", "Hello,  multiple words with space !")]
        public void Asset_That_Is_Formatting(string input, string expected)
        {
            Assert.That(Challenge.SayHello(input), Is.EqualTo(expected));
        }
    }
}