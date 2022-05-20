/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.
*/


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

string message = "Введите число N: ";

int N = GetNumber(message);
Console.Write($"{N} -> ");
int length = 1;
    while(N >= length)
    {
        if(N > length)
        {
            double Z = Math.Pow(length, 2);
            Console.Write($"{Z}, ");
        }
        else
        {
            double Z = Math.Pow(length, 2);
            Console.Write($"{Z}.");
        }
        length++;
    }