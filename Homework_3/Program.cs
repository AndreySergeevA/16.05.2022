/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 -> 1, 8, 27, 64, 125.
3 -> 1, 8, 27.
*/


int GetNumber(string message) 
{
    while(true) 
    {
        Console.WriteLine(message);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number)) 
        {
            if(number != 0) 
                return number;
            else 
            {
                Console.WriteLine("Число должно отличаться от 0. Введите другое число.");
            }
        }
        else 
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
            double Z = Math.Pow(length, 3);
            Console.Write($"{Z}, ");
        }
        else
        {
            double Z = Math.Pow(length, 3);
            Console.Write($"{Z}.");
        }
        length++;
    }
