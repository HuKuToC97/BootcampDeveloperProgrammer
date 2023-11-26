/// <summary>
/// Это класс, отвечающий за создание массива и работу с ним
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">колличество элиментов</param>
    /// <returns>Новый массив</returns>
    public static int[] Create(int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Метод создания массива с "this"
    /// </summary>
    /// <param name="n">колличество элиментов</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateV2(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Конвертирует массив в строку и выводит его в консоль
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строку с представлением массива</returns>
    public static string ConvertToStringAndPrintToTerminal(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        System.Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Заполняет масссив заданными seed псевдорандомными числами
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапозона генератора случайных чисел, по умолчанию 0</param>
    /// <param name="max">Верхняя граница диапозона генератора случайных чисел, по умолчанию 10</param>
    /// <param name="seed">Константа рандомайзера, по умолчанию 0</param>
    public static int[] FillRandomConst(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = new Random(seed);
        return array = array.Select(item => random.Next(min, max)).ToArray();
    }

    /// <summary>
    /// Заполняет масссив псевдорандомными числаси  
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапозона генератора случайных чисел, по умолчанию 0</param>
    /// <param name="max">Верхняя граница диапозона генератора случайных чисел, по умолчанию 10</param>
    public static int[] FillRandomRandom(this int[] array, int min = 0, int max = 10)
    {
        return array = array.Select(item => Random.Shared.Next(min, max)).ToArray(); //Это для без вышележашей строчки
    }

    /// <summary>
    /// Заполняет масссив заданными seed псевдорандомными числами
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапозона генератора случайных чисел, по умолчанию 0</param>
    /// <param name="max">Верхняя граница диапозона генератора случайных чисел, по умолчанию 10</param>
    /// <param name="seed">Константа рандомайзера, если не задать, то рандомная</param>
    public static int[] FillRandomUpDate(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        // Это по простому:
        // Random random;
        // if (seed == 0) random = new Random();
        // else random = new Random(seed);
        return array = array.Select(item => random.Next(min, max)).ToArray();
    }


}