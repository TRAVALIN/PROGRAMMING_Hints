/* Задание данных в массив с консоли */

int size = 10;
int[] arr = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите целое число:");
    string input = Console.ReadLine();
    arr[i] = Convert.ToInt32(input);
    i++;
}
foreach (var item in arr)
{
    Console.Write(item + " ");
}