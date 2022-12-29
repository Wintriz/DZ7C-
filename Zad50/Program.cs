// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] array = new int[3, 4];
Console.WriteLine("Введите число для проверки:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();

}
int num = int.Parse(Console.ReadLine()!);
int a = 0;
int b = 0;
bool IsNumberInArray = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            IsNumberInArray = true;
            a = i;
            b = j;
            Console.WriteLine($"Число - {num} есть в массиве c индексом: {a};{b}. ");
        }

    }

}
if (IsNumberInArray == true)
{
    Console.WriteLine();
}
if (IsNumberInArray == false)
{
    Console.WriteLine("Числа в массиве нет.");
}


