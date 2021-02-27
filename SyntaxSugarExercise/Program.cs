using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;
            //    if (answer < 9)
            //    {
            //        response = answer + " is less than nine";
            //    }
            //    else
            //    {
            //        response = answer + " greater than or equal to nine";
            //    }
            //    Console.WriteLine(response);
            //
          
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";  // sample 1
            Console.WriteLine(response);



            var answerb = 10;
            var responseb = (answerb < 9) ? "is less than nine" : "greater than or equal to nine";  // sample 2
            Console.WriteLine($"{answerb} {responseb}");
        }
        
    }

}