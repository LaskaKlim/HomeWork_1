﻿Console.Write("Введите первое число ");

int numberA = Convert.ToInt32 (Console.ReadLine());
 
Console.Write ("Введите второе число ");

int numberB = Convert.ToInt32 (Console.ReadLine());

int max = 0;
int min = 0;

if (numberA > numberB)
{
     max = numberA;
     min = numberB;
} 
else 
    max = numberB;
    min = numberA;


Console.WriteLine ( "max " + max);
Console.WriteLine ("min " + min);
