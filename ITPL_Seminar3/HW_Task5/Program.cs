int a = 123456;
int x = a;
int countDigit = 0;
while (x != 0)
{
    x = x / 10;
    countDigit++;
}
int[] arr = new int[countDigit];
int i = 0;
int x1 = a;
while (i < countDigit)
{
    arr[i] = x1 % 10;
    Console.Write(arr[i] + " ");
    x1 = x1 / 10;
    //Console.WriteLine(x1);
    i = i + 1;
}

