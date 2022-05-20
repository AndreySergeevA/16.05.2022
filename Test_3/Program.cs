/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
int GetNumber1(string messageA) // получает число
{
    while(true) // бесконечный цикл, пока пользователь не введет число соответствующее условиям( 0 и буквы нельзя)
    {
        Console.WriteLine(messageA);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number)) // происходит преобразование строковой величины в число
        {
            return number;
        }
        else // если ввели буквы
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int GetNumber2(string messageB) // получает число
{
    while(true) // бесконечный цикл, пока пользователь не введет число соответствующее условиям( 0 и буквы нельзя)
    {
        Console.WriteLine(messageB);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number)) // происходит преобразование строковой величины в число
        {
            return number;
        }
        else // если ввели буквы
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

string messageAXa = "Введите число хa: ";
string messageAYa = "Введите число уa: ";

int xa = GetNumber1(messageAXa);
int ya = GetNumber1(messageAYa);

string messageBXb = "Введите число хb: ";
string messageBYb = "Введите число уb: ";

int xb = GetNumber2(messageBXb);
int yb = GetNumber2(messageBYb);

double Za = Math.Pow((xb - xa),2);
double Zb = Math.Pow((yb - ya),2);

double sqrt = Math.Sqrt(Za + Zb);
Console.WriteLine(sqrt);