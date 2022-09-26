//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Позиция в строке");
int numbersRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Позиция в столбце");
int numbersColomns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [3,3];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1,5);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
if (numbersRows > array.GetLength(0) || numbersColomns > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента равно {array[numbersRows -1, numbersColomns -1]}");
}
