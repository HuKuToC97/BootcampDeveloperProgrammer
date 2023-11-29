
using System.ComponentModel;
using System.Runtime.InteropServices;

// int sizearray = 5;
// int[] array = new int[sizearray];
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($"Введите число для массива размером {array.Length}, для индекса [{i}]: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("[" + string.Join(" ", array) + "]"); // ВЫвод через пробел 


// System.Console.WriteLine(array[3]);
// Сложность O(1)


// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     sum += array[i];
// }
// System.Console.WriteLine($"Сумма равна {sum}");

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