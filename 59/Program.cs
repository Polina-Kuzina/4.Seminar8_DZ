// 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int[] sumarray = new int[m];
int sum = 0;
Console.WriteLine("Сумма чисел по строкам:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[i, j];
    }
    sumarray[i] = sum;
    Console.WriteLine(sumarray[i] + " ");
    sum = 0;
}
int kmin = 0;
for (int k = 1; k < m; k++)
{
    if (sumarray[k] < sumarray[kmin])
    {
        kmin = k;
    }
}
Console.WriteLine("Индекс строки с наименьшим элементом = " + kmin);