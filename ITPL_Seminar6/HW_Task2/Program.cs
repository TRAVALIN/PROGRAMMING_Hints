﻿/*
Задача 2: Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные.

“aBcD1ef!-” => “abcd1ef!-”
*/

string str = "aBcD1ef!-";
string result = str.ToLower();
Console.Write(result);