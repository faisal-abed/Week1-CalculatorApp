Console.WriteLine("Type the first number followed by the enter key");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the second number followed by the enter key");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int result = firstnumber + secondnumber;
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstnumber, secondnumber, result);
Console.ReadKey();