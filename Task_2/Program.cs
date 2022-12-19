/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Решение: 
найдем х : k1 * x + b1 = k2 * x + b2;  k1 * x - k2 * x = b2 - b1
x = (b2 - b1)/(k1 - k2); y = k1 * x + b1

требуется проверка: (k1 - k2) != 0  
*/

Console.Clear();
Console.WriteLine("Hello, World!");

double CheckInputNumber(string Text)

{
    Console.ForegroundColor = ConsoleColor.Yellow;

    double number;
    string text;

    while (true)
    {
        Console.Write(Text);
        text = Console.ReadLine();

        if (double.TryParse(text, out number)) break;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
        Console.ResetColor();
    }
    Console.ResetColor();
    return number;
}


void EnterCheckCoefficients(out double k1, out double k2)
{
    while (true)
    {
        k1 = CheckInputNumber("Введите коэффициент к1 первого уравнения : ");
        k2 = CheckInputNumber("Введите коэффициент к2 второго уравнения : ");

        if (k1 != k2) break;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Коэффициенты к1 и к2 не должны быть равны, повторите ввод.");
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Green;

System.Console.WriteLine("\nОпределим координаты точки пересечения двух прямых, заданных уравнениями :\ny = k1 * x + b1, y = k2 * x + b2\n");

EnterCheckCoefficients(out double k1, out double k2);

double b1 = CheckInputNumber("Задайте значение переменной уравнения b1 :");

double b2 = CheckInputNumber("Задайте значение переменной уравнения b2 :");

double X, Y;

X = Math.Round(((b2 - b1) / (k1 - k2)), 2);

Y = Math.Round((k1 * X + b1), 2);

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"\nТочка пересечения двух заданных прямых имеет координаты ( X ; Y ) : ( {X} ; {Y} )\n");
Console.ResetColor();

