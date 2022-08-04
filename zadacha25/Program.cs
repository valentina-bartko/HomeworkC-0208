// Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

// Числа автоматически генерируются из диапазона от 1 до 10.

double A = 0;
double B = 0;
double X = 0;

// Метод выбора рандомных чисел
void Random(double a, double b)
{
    a = new Random().Next(1, 11);
    b = new Random().Next(1, 11);
    A = a;
    B = b;
}

// Метод возведения в степень
void Exponent(double a, double b, double x)
{
    x = Math.Pow(a, b);
    X = x;
}

Random(A, B);
Exponent(A, B, X);
Console.Write($"{A}, {B} -> {X}");