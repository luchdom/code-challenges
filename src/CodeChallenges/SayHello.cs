using System;
using System.Collections.Generic;
namespace CodeChallenges
{
    public class Challenge
    {
        // Complete this function to return either
        // "Hello, [name]!" or "Hello there!"
        // based on the input
        public static string SayHello(string name)
        {
            // You can print to STDOUT for debugging like you normally would:
            var output = !string.IsNullOrEmpty(name) 
                ? $"Hello, {name}!"
                : "Hello there!";
            Console.WriteLine(output);

            // but you need to return the value in order to complete the challenge
            return output; // TODO: return the correct value
        }

    }
}
