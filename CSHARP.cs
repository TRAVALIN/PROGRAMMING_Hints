
// рандомные значения, например, при зполнении массивов
Random rnd = new Random();
matrix[i, j] = rnd.Next(1, 11);
array[i] = rnd.Next(1, 11);

// к сумме цифр числа
while(value > 0) ///- !!! не стоит ориентироваться на количество цифр в числе
// так намного проще
    {
        sum = sum + value % 10;
        value = value / 10;
    }

/* работа с функциями наиболее интересно lesson4:Task2 и Seminars5-7
(рекурсия 7, строки 6) по строкам Task 2.
*/

Console.WriteLine(string.Join(", ", result2)); // здесь образуется строка и с помощью 
// функции Join (присоединить) выводятся значения через запятую
Console.WriteLine(string.Join(" : ", result3));
Console.WriteLine(string.Join(" :\n", result3));

var result2 = input.Split(", ").Select(item => int.Parse(item)).ToArray(); 
// Pars преобразование в число, ToArray в массив, 
// Select выбирает item и передаёт их в Parse на преобразование

var result2 = input.Split(", ").
            Select(item => int.Parse(item) * 10).ToArray();


            
           
break; // позволяет прервать ближайший внешний цикл
return; // тоже позволяет прервать цикл и при этом завершает функцию
continue; // начинает новую итерацию ближайшего внешнего цикла
// применяется когда возникло условие, при котором оставшиеся инструкции
// можно пропустить
