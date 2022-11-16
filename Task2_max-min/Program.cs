// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2) 
{
    Console.WriteLine($"Number {num1} is the maximum of the two numbers");
}
else 
{
    Console.WriteLine($"Number {num2} is the maximum of the two numbers");
}