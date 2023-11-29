

internal class Program
{
    private static void Main(string[] args)
    {
        void SortSelection(int[] collection)
        {
            int size = collection.Length;
            for (int i = 0; i < size - 1; i++)
            {
                int pos = i;
                for (int j = i+1; j < size; j++)
                {
                    if (collection[j] < collection[pos]) pos = j;

                }
                int temp = collection[i];
                collection[i] = collection[pos];
                collection[pos] = temp;

            }
        }
        
        
        int[] array = [1, 3, 2, 6, 3, 5, 3];

        System.Console.WriteLine($"[{string.Join(" ", array)}]");
        SortSelection(array);
        System.Console.WriteLine($"[{string.Join(" ", array)}]");



    }
}