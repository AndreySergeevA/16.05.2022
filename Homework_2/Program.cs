/* Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15,84
A (7,-5, 0); B (1,-1,9) -> 11,53
*/
int GetNumber1(string messageA)
{
    while(true) 
    {
        Console.WriteLine(messageA);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number)) 
        {
            return number;
        }
        else 
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int GetNumber2(string messageB) 
{
    while(true) 
    {
        Console.WriteLine(messageB);
        string valueFromConsole = Console.ReadLine(); 

        if(int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else 
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}


string messageAXa = "Введите число х1: ";
string messageAYa = "Введите число у1: ";
string messageAZa = "Введите число z1: ";

int x1 = GetNumber1(messageAXa);
int y1 = GetNumber1(messageAYa);
int z1 = GetNumber1(messageAZa);

string messageBXb = "Введите число х2: ";
string messageBYb = "Введите число у2: ";
string messageBZb = "Введите число z2: ";

int x2 = GetNumber2(messageBXb);
int y2 = GetNumber2(messageBYb);
int z2 = GetNumber2(messageBZb);

double Zx = Math.Pow((x2 - x1),2);
double Zy = Math.Pow((y2 - y1),2);
double Zz = Math.Pow((z2 - z1),2);

double sqrt = Math.Sqrt(Zx + Zy + Zz);
Console.WriteLine(sqrt);