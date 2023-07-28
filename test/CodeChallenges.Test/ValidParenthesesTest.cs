namespace CodeChallenges.Test
{
    [TestFixture]
    public class ValidParenthesesTest
    {
        [TestCase(true, "()")]
        [TestCase(true, "()[]{}")]
        [TestCase(false, "(]")]
        public void Assert_That_Validate_Parentheses(bool expected, string input)
        {
            Assert.That(new ValidParentheses().IsValid(input), Is.EqualTo(expected));
        }
    }
}
