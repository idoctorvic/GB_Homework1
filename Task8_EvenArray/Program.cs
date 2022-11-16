// Напишите программу, которая на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}

// Version2
// int count = 2;
// if (num < 2)
// {
//     Console.WriteLine("Nothing to print");
// }
// else
// while (count < num)
// {
//     {
//         Console.WriteLine(count);
//         count += 2;
//     }
// }