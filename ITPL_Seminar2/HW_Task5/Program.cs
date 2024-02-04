/* ПОДСКАЗКИ ДЛЯ ВЫПОЛНЕНИЯ ДОМАШНЕЙ РАБОТЫ
К СЕМИНАРУ 2 

/* в условии знак & = и    знак | = или
знак ! = не

int a = 123; 
if (!(a < 100 & a < 1000) & a % 23 == 0) - при такой записи все условия должны быть true (истина)
if (a < 100 && a < 1000) - при такой записи если хотябы один результат true (истина),
то и весь результат будет true (истина)
тоже самое и для знаков !! || 
*/


int b = 12345;
Console.WriteLine(b.ToString().Length);

int a = 123456;
int countDigit = 0;
int x = a;

while (x != 0)
{
   x /= 10; // результат деления х на 10 или x = x / 10
   countDigit++;
}
Console.WriteLine(countDigit);


int a1 = 123456;
//Console.WriteLine(a.ToString().length);
int countDigit1 = 0;
int x1 = a1;

while (x1 != 0)
{
   Console.WriteLine(x1);
   x1 = x1 / 10; // можно записать: x1 /= 10; - результат деления х1 на 10
   countDigit1++;
}
Console.WriteLine(countDigit1);