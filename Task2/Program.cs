// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int s)
{
    int result = 0;
    while (s > 0)
    {
        result = result + s % 10;
        s = s / 10;
    }
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int s = EnterData("Введите число: ");
int result = Sum(s);
Console.WriteLine("Сумма цфр в числе " + s + " равна " + result);
