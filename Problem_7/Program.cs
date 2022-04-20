// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Примечания: 
// 1. Поскольку НЕПОНЯТНО, как/кем задается число, я решила, что попробую задать рандомно.
// 2. Встал вопрос, скольки значное число задать. Решила взять из всего диапазона 32 бит 
// (если не ошибаюсь, называется "длинное целое").
// 2. Метод скорее всего можно (я уверена!) сделать компактнее, но меня хватило только на такой.

void ThirdDigitRandomNum(int number)
{
    if (number > 10 & number < 100)
    {
        Console.WriteLine("There is no third digit in this number.");
    }
    else
        {
        if (number > 100 & number < 1000)
        {
            number = number % 10;
        }
        else
        {
            if (number > 1000 & number < 10000)
            {
                number = number / 10 % 10;
            }
            else
            {
                if (number > 10000 & number < 100000)
                {
                    number = number / 100 % 10;
                }
                else
                {
                    if (number > 100000 & number < 1000000)
                    {
                        number = number / 1000 % 10;
                    }
                    else
                    {
                        if (number > 1000000 & number < 10000000)
                        {
                            number = number / 10000 % 10;
                        }
                        else
                        {
                            if (number > 10000000 & number < 100000000)
                            {
                                number = number / 100000 % 10;
                            }
                            else
                            {
                                if (number > 100000000 & number < 1000000000)
                                {
                                    number = number / 1000000 % 10;
                                }
                                else
                                {
                                    if (number > 1000000000 & number < 2147483647)
                                    {
                                        number = number / 10000000 % 10;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    Console.WriteLine("The third digit from the left is " + number + ".");
}
int x = new Random().Next(-2147483647, 2147483647);
Console.WriteLine(x);
if (x < 0)
{
    x = Math.Abs(-x);
}
ThirdDigitRandomNum(x);