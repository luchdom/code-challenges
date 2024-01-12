
namespace CodeChallenges.Test
{
    [TestFixture]
    public class LikeFormatterTest
    {
        [Test]
        public void EmptyList()
        {
            var names = new List<string>();
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("no one likes this"));
        }

        [Test]
        public void OneItem()
        {
            var names = new List<string>
            {
                "Amy"
            };
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("Amy likes this"));
        }

        [Test]
        public void TwoItems()
        {
            var names = new List<string>
            {
                "Amy",
                "Bob"
            };
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("Amy and Bob like this"));
        }

        [Test]
        public void ThreeItems()
        {
            var names = new List<string>
            {
                "Amy",
                "Bob",
                "Carol"
            };
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("Amy, Bob and Carol like this"));
        }

        [Test]
        public void FourItems()
        {
            var names = new List<string>
            {
                "Amy",
                "Bob",
                "Carol",
                "Doug"
            };
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("Amy, Bob and 2 others like this"));
        }

        [Test]
        public void FiveItems()
        {
            var names = new List<string>
            {
                "Amy",
                "Bob",
                "Carol",
                "Doug",
                "Erin"
            };
            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("Amy, Bob and 3 others like this"));
        }

        [Test]
        public void FiveHundredItems()
        {
            var names = new List<string>
            {
                "A",
                "B"
            };

            for (int i = 0; i < 498; i++)
                names.Add("X");

            Assert.That(LikeFormatter.HumanFriendlyLikes(names), Is.EqualTo("A, B and 498 others like this"));
        }
    }
}
