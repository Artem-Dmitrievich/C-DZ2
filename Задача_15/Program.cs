﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня: ");
int a = Convert.ToInt32(Console.ReadLine());
void f (int a)
{
    if(a == 6 || a == 7)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
f (a);