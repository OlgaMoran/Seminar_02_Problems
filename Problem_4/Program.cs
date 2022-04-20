// 4. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// если вводить рандомное число, то вот так (правда редко можно попасть):
// int a = new Random().Next(0, 1000); 
// Console.WriteLine(a);

int a = 160;
if (a % 7 == 0 & a % 23 == 0)
{
    Console.WriteLine(a + " is a multiple of 7 and 23.");
}
else
{
    Console.WriteLine(a + " is not a multiple of 7 and 23.");
}