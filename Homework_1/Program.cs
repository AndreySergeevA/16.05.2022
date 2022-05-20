/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

string EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    string numberSTR = "";
    while (readlineFromStrToInt){
        Console.Write("Enter 9999 < number < 100000 : ");
        numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            if (numberSTR.Length != 5 || numberSTR[0] == '-') Console.WriteLine("Неверно, введите число находящееся в диапазоне!");
            else readlineFromStrToInt = false;
        }  
    }
    return numberSTR;
}
/* Функция Формированичя результата */
string polindromeResult(int sum, string number){
    string reuslt = (sum == 2 )? $"Да, число {number}-> палиндром" : $"Нет, число {number}-> не палиндром";
return reuslt;
}
/* Функцмя проверки на полимер и вывод результата */
string polindromeTest(string number)
{
    int sum =0;
    string result = "";
    for (int i = 0; i < 2; i++){
        if (number[i] == number[number.Length-i-1]) sum++;
    }
    result = polindromeResult(sum,number);
return result;
}

/* Сама программа */ 
string number = EnterNumberTest();

Console.WriteLine(polindromeTest(number));

Console.ReadLine();