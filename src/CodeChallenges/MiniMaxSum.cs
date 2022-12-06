using System;
namespace CodeChallenges
{
    public class MiniMaxSum : IChallenge
    {
        public void Run()
        {
            //Eg.: new List<long> {5, 5, 5, 5, 5 } or new List<long> {9, 5, 7, 3, 2 }
            List<long> arr = new List<long> { 1,2,3,4,5 };//Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            var results = new List<long>();
            for(int i = 0; i < arr.Count; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i != j)
                        sum += arr[j];
                }
                results.Add(sum);
            }

            Console.WriteLine($"{results.Min()} {results.Max()}");
            
        }
    }
}

