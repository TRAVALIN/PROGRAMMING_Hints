// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i1 = 5;
int i2 = 8;
int sum = i1 + i2;
Console.WriteLine(sum);

long l1 = 10;
long sum2 = l1 + i2;
Console.WriteLine(sum2);

double d1 = 5.23235416;
double sum3 = sum2 + d1;
Console.WriteLine(sum3);

int product1 = i1 * i2;
double product2 = sum3 * sum2;
long product3 = sum2 * i1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

// ВАЖНО!!! Необходимо правильно задавать 
// тип данных, при действиях с различными типами данных,
// результату действия присваевается тип данных более вместительный,
// а при делении целых чисел, когда результат является дробным числом,
// если назначить типу данных целое число, то на экран выводится
// значение целой части, без дробной части.

int qoutient1 = i1 / i2;
Console.WriteLine(qoutient1);

// даже назначив тип данных для результата деления числом дробным
// получим результат int без дробной части потому, что 
// в операции принимают участие только целые числа:
double qoutient3 = i1 / i2;
Console.WriteLine(qoutient3);

d1 = 9;
double qoutient2 = d1 / i1;
Console.WriteLine(qoutient2);