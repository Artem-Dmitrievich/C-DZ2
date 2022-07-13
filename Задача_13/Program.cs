//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int n = Convert.ToInt32(Console.ReadLine());
string i = Convert.ToString(n);
if (i.Length > 2)
{
    Console.WriteLine("третья цифра -> " + i[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}

