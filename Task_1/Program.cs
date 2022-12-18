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

int[] ARRAY()
{
   int M = CheckInputNumber("Задайте количество чисел для ввода : ");
   
   int[] arr = new int[M];
   
   for(int i = 0; i < M ; i++)
   {
      arr[i] =CheckInputNumber($"Введите {i+1}-й элемент : ");
   }
   return arr;
}

void NumMoreNull(int[] array, out int Numbers)
{ 
   Numbers = 0;
   
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
      { 
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write(array[i]);
        Console.ResetColor();
        System.Console.Write(" | ");
        Numbers++;
      }
      else 
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write(array[i]);
        Console.ResetColor();
        System.Console.Write(" | ");
      }    
   }
}

int[] array = ARRAY();

System.Console.WriteLine("\nВведены следующие значения чисел : \n");

NumMoreNull(array, out int Numbers);

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine($"\n\nB данном массиве чисел количество значений больше нуля = {Numbers}\n");
Console.ResetColor();
