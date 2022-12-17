/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Hello, World!");

/*   Вариант введения массива в одну строку, но в диапазоне от 0 до 9

int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 8; i++)
{
a[i] = Console.ReadKey().KeyChar - '0';
Console.Write(", ");
}
System.Console.WriteLine("\n[ " + string.Join(" , ", a) + " ]");
*/

/*  Вариант введения массива в одну строку с разделением значений запятой:

int[] ar = Console.ReadLine().Split(new char[]{','}, 
StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();
System.Console.WriteLine("\n[ " + string.Join(" , ", ar) + " ]");
*/
