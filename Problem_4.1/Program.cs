// 4.1. Напишите программу, которая принимает на вход число 
// и проверяет: 1) кратно ли оно и 7, и 23; 2) кратно ли оно только 7; 
// 3) кратно ли оно только 23.

// если вводить рандомное число, то вот так (правда редко можно попасть):
// int a = new Random().Next(0, 1000); 
// Console.WriteLine(a);

int a = 160;
if (a % 7 == 0 & a % 23 == 0)
{
    Console.WriteLine(a + " is a multiple of both 7 and 23.");
}
else
{
    if (a % 7 == 0 & a % 23 != 0)
    {
        Console.WriteLine(a + " is a multiple of 7.");
    }
    else
    {
        if (a % 7 != 0 & a % 23 == 0)
        {
            Console.WriteLine(a + " is a multiple of 23.");
        }
        else
        {
            if (a % 7 != 0 & a % 23 != 0)
            {
                Console.WriteLine(a + " is not a multiple of either 7 or 23.");
            }
        }
    }
}