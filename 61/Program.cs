// 61: Найти произведение двух матриц.
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
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
int[,] arrayOne = new int[3, 4];
FillArray(arrayOne);
Console.WriteLine("Матрица 1");
PrintArray(arrayOne);
int[,] arrayTwo = new int[4, 3];
FillArray(arrayTwo);
Console.WriteLine("Матрица 2");
PrintArray(arrayTwo);
if (arrayOne.GetLength(0) != arrayTwo.GetLength(1)) Console.WriteLine("Умножение матриц не возможно");
else
{
    int[,] arrayProduct = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    Console.WriteLine("Произведение матриц");
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                arrayProduct[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
            Console.Write(arrayProduct[i, j] + " ");
        }
        Console.WriteLine();
    }
}