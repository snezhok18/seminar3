// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите 5-значное число");
string num = (Console.ReadLine()!);

if (num.Length == 5)
{

if (num[0] == num[4] && num[1] == num[3])
{
    System.Console.WriteLine($"Число {num} является полиандром.");   
}
else
{
    System.Console.WriteLine($"Число {num} не полиандр.");
}

}
else
{
    System.Console.WriteLine("Вводите ТОЛЬКО 5-значное число!");
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки А2: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки А3: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В1: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В3: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z1),2)),2);
System.Console.WriteLine($"Получится: {result}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(number);
System.Console.WriteLine("Результат: ");
int i = 1;
while (i <= number)
{
    int result = Convert.ToInt32(Math.Pow(i, 3));
    i++;
    Console.Write(result + " ");
}