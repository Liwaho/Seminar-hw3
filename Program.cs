/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.Write("Введите пятизначное число: ");
int pal = int.Parse(Console.ReadLine());

if 

else Console.WriteLine("Это не палиндром.")
*/

/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
Console.Write("Введите x координаты А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y координаты А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z координаты А: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите x координаты Б: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y координаты Б: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z координаты Б: ");
int z2 = int.Parse(Console.ReadLine());

double l = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между двумя точками = {l:f2}");
*/

/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double q = Math.Pow(i,2);
    Console.Write($"{q} ");
}
