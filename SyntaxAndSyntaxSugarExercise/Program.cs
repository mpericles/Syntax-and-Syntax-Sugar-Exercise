using System;
using System.Net.NetworkInformation;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Guidance from Class Notes


            //inferred typing
            //this is infered because we are using Var instead of Int
            //if we were using int the typing would be explicit 
            // Explicit Typing; string firstName = "John"
            // Inferred Typing: var firstName = "John";
            var answer = 4;
            string response;
            if (answer < 9)
            {
              response = answer + " is less than nine";
            }
            else
            {
               response = answer + " is greater than or equal to nine";
            }
            Console.WriteLine(" ");
            Console.WriteLine("inferred typing");
            //Console.WriteLine("var answer = 4");
            Console.WriteLine(response);

            //string interpolation
            //interpolation is calling on variables or strings 
            //int answer = 4;
            //string response;
            if (answer < 9)
               {
               string lnine =  " is less than nine";
               response = $"{answer}{lnine}";
                //response = $"{answer} is less than nine";
               Console.WriteLine(" ");
               Console.WriteLine("string interploation");
               Console.WriteLine(response);
               }
                else
               {
               //    response = answer + " is greater than or equal to nine";
                      response = $"{answer} is greater than or equal to nine";
               }

            //ternary operator
            //var answer = 4;
            //var response;
                Console.WriteLine(" ");
                Console.WriteLine("ternary operator");
                response = (answer < 9)?  $"{answer} is less than nine": $"{answer} is greater than or equal to nine";
                Console.WriteLine(response);
     

        }
    }
}
