using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            //    if (answer < 9)
            //    {
            //        response = answer + " is less than nine";
            //    }
            //    else
            //    {
            //        response = answer + " greater than or equal to nine";
            //    }
            //    Console.WriteLine(response);
            //}
            var response = (answer < 9) ? " is less than nine" : " is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }

}