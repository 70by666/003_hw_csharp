// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void MyFunc (int arg)
{
    for (int i = 1; i <= arg; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
}


MyFunc(3);
System.Console.WriteLine();
MyFunc(5);
System.Console.WriteLine();
MyFunc(7);
System.Console.WriteLine();
MyFunc(10);
System.Console.WriteLine();
MyFunc(15);
