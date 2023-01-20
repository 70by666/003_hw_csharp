// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double MyFunc(int[] arg1, int[] arg2)
{
    return Math.Round(Math.Sqrt(Math.Pow(arg2[0] - arg1[0], 2) + 
                      Math.Pow(arg2[1] - arg1[1], 2) +
                      Math.Pow(arg2[2] - arg1[2], 2)), 2);
}


int[] arrA1 = {3, 6, 8};
int[] arrB1 = {2, 1, -7};

int[] arrA2 = {7, -5, 0};
int[] arrB2 = {1, -1, 9};

System.Console.WriteLine(MyFunc(arrA1, arrB1));
System.Console.WriteLine(MyFunc(arrA2, arrB2));
