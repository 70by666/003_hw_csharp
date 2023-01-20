// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void MyFunc(int arg)
{
    string num = arg.ToString();

    if (num.Length == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        {
            System.Console.WriteLine("+");
        }
        else
        {
            System.Console.WriteLine("-");
        }
    }
    else 
    {
        System.Console.WriteLine("error invalid number");
    }
}


MyFunc(14212);
MyFunc(12821);
MyFunc(23432);
MyFunc(123456);
MyFunc(123);
MyFunc(16661);
