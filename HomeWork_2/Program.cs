Console.Write("Введите первое число ");

int numberA = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе число ");

int numberB = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите третье число ");

int numberC = Convert.ToInt32 (Console.ReadLine());

int max = 0;

if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

if (numberC > max) max = numberC;

Console.WriteLine (" max " + max);

