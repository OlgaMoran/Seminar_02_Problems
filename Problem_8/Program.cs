//8. Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter the number of the day (from 1 to 7). ");
int a = Convert.ToInt32(Console.ReadLine());
void WorkdayWeekend(int day)
{
    if (day == 6 | day == 7)
    {
        if (day == 6)
        {
            Console.WriteLine("Hooray! It's Saturday! The weekend's started!");
        }
        else
        {
            Console.WriteLine("It's Sunday! Still one more day off!");
        }
    }
    else
    {
        if (day == 1)
        {
            Console.WriteLine("Sorry! Monday is a workday.");
        }
        else
        {
            if (day == 2)
            {
                Console.WriteLine("Sorry! Tuesday is a workday.");
            }
            else
            {
                if (day == 3)
                {
                    Console.WriteLine("Sorry! Wednesday is a workday.");
                }
                else
                {
                    if (day == 4)
                    {
                        Console.WriteLine("Sorry! Thursday is a workday.");
                    }
                    else
                    {
                        if (day == 5)
                        {
                            Console.WriteLine("Sorry! Friday is a workday.");
                        }
                    }
                }

            }
        }
    }
}
WorkdayWeekend(a);