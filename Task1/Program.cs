// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3,5 -> 243 (3⁵)
//2,4 -> 16


double Degree(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int A = EnterData("Введите 1 число: ");
int B = EnterData("Введите 2 число: ");
double result = Degree(A, B);
Console.WriteLine("Число " + A + " в степени числа " + B + " равен " + result);
