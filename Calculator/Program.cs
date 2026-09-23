using System.Globalization;

calculator();
void calculator()
{
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type the first number followed by the enter key");
     firstnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type the second number followed by the enter key");
     secondnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstnumber + secondnumber;
        Console.WriteLine($"Adding {firstnumber} and {secondnumber} equals {result}");   

    }
    else if (choice == 2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine($"Subtracting {firstnumber} from {secondnumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstnumber / secondnumber;
        Console.WriteLine($"Dividing {firstnumber} by {secondnumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine($"Multiplying {firstnumber} by {secondnumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }

    result = firstnumber + secondnumber;
    Console.WriteLine("The result is {0}", result);
    Console.ReadKey();
}