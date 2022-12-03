// int number = 0;
// string text = ""; //number = Convert.ToInt32(Console.ReadLine())
// text = Console.ReadLine();
// number = Convert.ToInt32(text);
// Console.WriteLine("Result "  +  number * number);

//Задача 1:

 Console.Write("Введите первое число ");

int numberA = Convert.ToInt32 (Console.ReadLine());
 
 Console.Write ("Введите второе число ");

 int numberB = Convert.ToInt32 (Console.ReadLine());

 if (numberA == numberB * numberB)
 {
    Console.Write("Да");
 }
else
{
  Console.Write ("Нет");  
}

