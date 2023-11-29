System.Console.Write("Введите число до которого вывести табл. умножения: ");
int m = Convert.ToInt32(System.Console.ReadLine());
int[,] matrix = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < i+1; j++)
    {
        System.Console.Write($"{matrix[i, j]}\t");
    }
    System.Console.WriteLine();
}