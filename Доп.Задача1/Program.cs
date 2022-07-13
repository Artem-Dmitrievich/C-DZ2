//Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, после чего дробная часть копеек отбрасывается.
//Требуется определить: через сколько лет вклад составит не менее Y рублей.
//Входной файл INPUT.TXT содержит три натуральных числа: X, P и Y (X,Y ≤ 1000, P ≤ 100).

//Основная формула(для себя)
//Sn = S(1 + x / 100)*n; S = первоначальная сумма вклада, x = процент, Sn = сумма конечная, n-срок вклада
Console.WriteLine("сумма вклада: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой %: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Желаемая сумма: ");
int y = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (x < y)
{
    x = x + ((x * p)/100);
    i = i + 1;
}
Console.Write("Понадобится: ");
Console.Write(i);