/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.WriteLine("Hello, World!");

int CheckInputNumber(string Text)
{
    Console.ForegroundColor = ConsoleColor.Blue;

    int number;
    string text;

    while (true)
    {
        Console.Write(Text);
        text = Console.ReadLine();

        if (int.TryParse(text, out number)) break;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
        Console.ResetColor();
    }
    Console.ResetColor();
    return number;
}

int[] ArCopy(int[] array, int Length)
{
    int[] Copy = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Copy[i] = array[i];
    }
    return Copy;
}

int[] MadeArray()
{
    Console.ForegroundColor = ConsoleColor.Green;

    System.Console.WriteLine("\nВводите числа до заполнения массива, а если утомитесь - жмите спасительный код - 011 !\n");

    const int M = 1000;
    int count = 0;
    int[] arr = new int[M];

    for (int i = 0; i < M; i++)
    {
        arr[i] = CheckInputNumber($"Введите {i + 1}-й элемент : ");
        if (arr[i] == 011 || i == 999) break;
        count++;
    }

    int[] arrCopy = ArCopy(arr, count);

    return arrCopy;
}

void NumMoreNull(int[] array, out int Numbers, out int arL)
{
    Numbers = 0;
    arL = array.Length;

    //for (int i = 0; i < array.Length; i++)
    foreach (int ari in array)
    {
        if (ari > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(ari);
            Console.ResetColor();
            System.Console.Write(" | ");
            Numbers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(ari);
            Console.ResetColor();
            System.Console.Write(" | ");
        }
    }
}

int[] array = MadeArray();

System.Console.WriteLine("\nВведены следующие значения чисел : \n");

NumMoreNull(array, out int Numbers, out int arL);

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine($"\n\nB данном массиве из {arL} чисел количество значений больше нуля = {Numbers}\n");
Console.ResetColor();
