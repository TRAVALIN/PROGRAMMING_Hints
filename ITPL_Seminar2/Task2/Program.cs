/* Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1 */


/* в папке Math хранятся различные математические функции
int result = Math.Sqrt(    ); // квадратный корень
double result = Math.Pow(8, 7); // возведение в степень дабл потому что могут быть не целые числа
*/

int a = 487;
int secondDigit = a / 10 % 10;
int thirdDigit = a % 10;
double result = Math.Pow(secondDigit, thirdDigit);
Console.WriteLine(result);
Console.WriteLine(thirdDigit);
Console.WriteLine(secondDigit);

int pow = 1;
int count = 0;

while (count < thirdDigit)
{
    pow = pow * secondDigit;
    count++;
}
Console.WriteLine(pow);

int pow2 = 1;
for (int i = 0; i < thirdDigit; i++)
{
    //pow2 = pow2 * secondDigit;
    pow2 *= secondDigit;
}
Console.WriteLine(pow2);