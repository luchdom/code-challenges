
using System.Globalization;

namespace CodeChallenges
{
    public class PlusMinus
    {
        public void ReadConsoleAndExecute()
        {
            //Eg.: arr = new List<int> { 0, 3, -1 };
            List<int> arr = Console.ReadLine()
                                   .TrimEnd()
                                   .Split(' ')
                                   .ToList()
                                   .Select(arrTemp => Convert.ToInt32(arrTemp))
                                   .ToList();

            //Execute
            CalculateRatio(arr);
        }

        private void CalculateRatio(List<int> arr)
        {
            int positive = 0, negative = 0, zero = 0;

            arr.ForEach((n) =>
            {

                switch (n)
                {
                    case int x when x < 0:
                        negative++;
                        break;
                    case int x when x == 0:
                        zero++;
                        break;
                    case int x when x > 0:
                        positive++;
                        break;
                    default:
                        break;
                }
            });

            PrintResult(positive, arr.Count);
            PrintResult(zero, arr.Count);
            PrintResult(negative, arr.Count);
        }

        private static void PrintResult(int result, int arrayCount)
        {
            if (result > 0)
            {
                Console.WriteLine(((decimal)result / (decimal)arrayCount)
                    .ToString("N6", CultureInfo.InvariantCulture));
            }
        }
    }
}

