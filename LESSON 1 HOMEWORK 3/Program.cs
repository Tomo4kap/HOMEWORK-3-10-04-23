Console.Write("Enter an integer: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1 % 2;
if (number2 == 0)
{
    Console.WriteLine($"{number1} is an even number");
}
else
{
    Console.WriteLine($"{number1} is an odd number");
}