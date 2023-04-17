Console.WriteLine("Please input a number");
int number = int.parse(Console.ReadLine());
FizzBuzz(number);

public static string FizzBuzz(int userInput)
{
    if (userInput == % 3 == 0)
    {
      return "fizz";
    }
    else if (userInput % 5 == 0)
    {
      return "buzz";
    }
    else if (userInput % 3 == 0 && userInput % 5 == 0)
    {
      return "fizzbuzz";
    }
    else
    {
       return "No fizzbuzz for you :(";
    }