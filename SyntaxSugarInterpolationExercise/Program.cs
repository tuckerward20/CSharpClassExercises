using System;

namespace SyntaxSugarInterpolationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;

            response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
