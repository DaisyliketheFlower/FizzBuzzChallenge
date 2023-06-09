namespace FizzBuzzChallenge;

public class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Please input a number");
        int number = int.parse(Console.ReadLine());
        var answer = FizzBuzz(number);
        Console.WriteLine(answer);
    }

     public static string FizzBuzz(int userInput)
    {
        var answer = "";

        if(userInput % 3 == 0)
        {
            answer += $"{userInput}";
        }
        if(userInput % 5 == 0)
        {
            answer += $"{userInput}";
        } 

        return answer;
        if (userInput % 3 == 0 && userInput % 5 == 0)
        {
            return "fizzbuzz";
        }
         else if (userInput % 5 == 0)
        {
            return "buzz";
        }
          if (userInput % 3 == 0)
        {
            return "fizz";
        }
        else
        {
            return "No fizzbuzz for you :(";
        } 
    }
}
