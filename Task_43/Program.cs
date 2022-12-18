/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
 // проверка корректности ввода числа
 
double CorrectNumber(string messege)
{
    bool isCorrect = false;
    double result = 0;
    while (! isCorrect)
    {
        Console.Write(messege);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else Console.Write("Введите корректное число -> ");
    }
    return result;
}

double b1 = CorrectNumber("Введите значение b1 -> ");
double k1 = CorrectNumber("Введите значение k1 -> ");
double b2 = CorrectNumber("Введите значение b2 -> ");
double k2 = CorrectNumber("Введите значение k2 -> ");

if (b1 == b2 && k1 == k2) Console.WriteLine("Две линии лежат друг на друга, все точки первой и второй линии сходятся");

if (b1 != b2 && k1 == k2) Console.WriteLine("Две линии линии паралельны они не пересекаються");

else
{
    double x = ((b2 - b1) / (k1 - k2));
    double y = k1 * x + b1;
    Console.WriteLine($"{x}, {y}");
}