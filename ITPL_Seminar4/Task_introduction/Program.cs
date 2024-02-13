/* создаём функцию которая будет создавать и заполнять
массив, созданный внутри функции
рандомными числами из заданного диапазона*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
    return array;
}

/* создаём функцию которая будет перезаполнять любой уже созданный массив
рандомными значениями из заданного диапазона */

int[] FillRandomArray(int[] array, int minValue, int maxValue)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
    return array;
}

/* Создаём функцию которая будет выводить
по порядку элементы любого массива на консоль */

void ShowPrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] array = CreateRandomArray(10, 1, 100);
ShowPrintArray(array);

int[] array2 = CreateRandomArray(15, 1, 100);
ShowPrintArray(array2);

int[] array3 = FillRandomArray(array, 1, 100);
ShowPrintArray(array3);
