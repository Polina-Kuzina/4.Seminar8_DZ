// 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 5];
Console.WriteLine("Исходный массив");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        // Console.Write(array[i,j] + " ");
    }
}
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int size = array.GetLength(1); size > 0; size--)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
            }
        }
    }
}
Console.WriteLine("Отсортированный массив");
PrintArray(array);

