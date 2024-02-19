/*

дополнительная информация по работе с строками и символами

*/

string[] str = { "sdf", "dfgj", "ldkjg"};
foreach (string item in str)
{
    Console.WriteLine(item + " ! ");
}
Console.WriteLine();

string[] strings = { 
        "sdf", 
        "dfgj", 
        "ldkjg"
};
for (int i = 0; i < strings.Length; i++)
{
    for (int j = 0; j < strings[i].Length; j++)
    {
        Console.Write($"-{str[i][j]}- ");
    }
    Console.WriteLine();
}

/*

PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar6\Task4> dotnet run
sdf ! 
dfgj ! 
ldkjg !

-s- -d- -f-
-d- -f- -g- -j-
-l- -d- -k- -j- -g-
*/