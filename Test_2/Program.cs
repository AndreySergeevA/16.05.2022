//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/* 
          |
    2     |     1
          |
----------0-----------
          |
    3     |     4
          |
*/

int GetQuarter()
{
    while (true)
    {
        Console.WriteLine("Введите четверть для выдачи диапазона: ");
        int quarterNum = Convert.ToInt32(Console.ReadLine());
        if (quarterNum != 1 && quarterNum != 2 && quarterNum != 3 && quarterNum != 4)
        {
            Console.WriteLine("Введите число от 1 до 4: ");
        }
        else
        {
            return quarterNum;
        }
    }
}

void GetRange(int quarterNum)
{
    if (quarterNum == 1) 
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (quarterNum == 2) 
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (quarterNum == 3) 
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else
    {
        Console.WriteLine("x > 0, y < 0");
    }
}

int giveQuater = GetQuarter();
GetRange(giveQuater);

