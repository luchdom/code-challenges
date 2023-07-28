using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    public class LikeFormatter
    {
        public const string NoLikesMessage = "no one likes this";
        public const string OneLikeMessage = "{0} likes this";
        public const string TwoLikesMessage = "{0} and {1} like this";
        public const string ThreeLikesMessage = "{0}, {1} and {2} like this";
        public const string FourOrMoreMessage = "{0}, {1} and {2} others like this";

        public static string HumanFriendlyLikes(List<string> names)
        {
            switch (names.Count)
            {
                case 0:
                    return NoLikesMessage;
                case 1:
                    return string.Format(OneLikeMessage, names.ToArray());
                case 2:
                    return string.Format(TwoLikesMessage, names.ToArray());
                case 3:
                    return string.Format(ThreeLikesMessage, names.ToArray());
                default:
                    return string.Format(FourOrMoreMessage, names[0], names[1], names.Count-2);
            }
        }
    }
}
