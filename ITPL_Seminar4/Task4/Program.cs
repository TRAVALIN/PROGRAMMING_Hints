int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int[] reversal_array = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    //int index_reversal_array = array.Length
    reversal_array[i] = array[(array.Length - 1)-i];
    Console.Write(reversal_array[i]);
}
