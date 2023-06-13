namespace FizzBuzzChallenge;

public class FizzBuzz
{
    public static int Buzz() 
    {
        Console.WriteLine("See if a number is divisble by 3 or 5");
            var userInput = int.Parse(Console.ReadLine());

           if(userInput % 3 == 0 && userInput % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
                return userInput;

            }
            else if(userInput % 3 == 0)
            {
                Console.WriteLine("Fizz");
               return userInput;
            }
            else if(userInput % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return userInput;
            }

            Console.WriteLine("it's not divisable by 3 or 5");
            return userInput;
            
    }
}
