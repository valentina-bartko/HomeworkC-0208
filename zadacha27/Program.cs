// Напишите метод, который принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Я понимаю задачу так: число натуральное, вводится пользователем.

int res = 0;
int x = 0;
int X = 0;
int y = 0;

// Метод получения числа
void Number (int a, int b)
{
Console.Write("Введите натуральное число: ");
a = Convert.ToInt32(Console.ReadLine());
b = a;
x = a;
X = b;
}

// Метод сложения цифр числа
void Sum (int a, int b, int c)
{
while (b > 0)
{
    a = b % 10;
    c = a + c;
    b = b / 10;
}
y = a;
x = b;
res = c;
}

// Метод печати
void Print ()
{
    Console.WriteLine($"{X} -> {res}");
}

Number (x, X);

Sum (y, x, res);

Print ();