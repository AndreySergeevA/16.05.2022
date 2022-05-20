/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
          |
    2     |     1
          |
----------0-----------
          |
    3     |     4
          |
*/

int GetQuarter(int x, int y) // получает четверть
{
    // мы тут сделаем логику, &&-это обозначает "и"
    if(x > 0 && y > 0) 
        return 1;
    else if(x > 0 && y < 0)
        return 4;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 2;
}

// функция,  которая получает число, введенное с клавиатуры
// + проверка на то, что ввели именно число
// + проверка, что число != 0
int GetNumber(string message) // получает число
{
    while(true) // бесконечный цикл, пока пользователь не введет число соответствующее условиям( 0 и буквы нельзя)
    {
        Console.WriteLine(message);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number)) // происходит преобразование строковой величины в число
        {
            if(number != 0) // не равно нулю
                return number;
            else // если ввели 0
            {
                Console.WriteLine("Число должно отличаться от 0. Введите другое число.");
            }
        }
        else // если ввели буквы
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от 0.");
        }
    }
}

string messageX = "Введите число х: ";
string messageY = "Введите число у: ";

int x = GetNumber(messageX);
int y = GetNumber(messageY);

int quater = GetQuarter(x, y);

Console.WriteLine($"Точка лежит в {quater} четверти");