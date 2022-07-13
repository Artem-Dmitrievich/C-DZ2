//В первый день спортсмен пробежал X километров. В каждый последующий день он увеличивал пробег на 15% от предыдущего дня. 
//По данному числу Y требуется определить номер дня, в который пробег спортсмена составил не менее Y километров.

//Входной файл INPUT.TXT содержит два положительных вещественных числа X и Y (X,Y ≤ 1000).

Console.WriteLine("Сколько пробежал в 1 день км: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("На какой % увеличиваем: ");
double p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кол-во км, которое будет бежать: ");
int y = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (x < y)
{
    x = x + ((x * p)/100);
    i++;
}
Console.Write("Номер дня: ");
Console.Write(i);






//int day1 = x; //1 день
//int day2 = (x + 15)/100;
//int day3 = (day2 + 15)/100;
//int day4 = (day3 + 15)/100;
//int day5 = (day4 + 15)/100;
//int day6 = (day5 + 15)/100;
//int day7 = (day6 + 15)/100;
