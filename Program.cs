// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Задача 19. Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine()!);
string NumberStr = Number.ToString();

if(NumberStr.Length == 5) {
    if(NumberStr[0] == NumberStr[4] && NumberStr[1] == NumberStr[3]) {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не палиндром");
}
else
Console.WriteLine("Введено некорректное число");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21. Введите координату точки а(x,y,z)");
int ax = int.Parse(Console.ReadLine()!);
int ay = int.Parse(Console.ReadLine()!);
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки b(x,y,z)");
int bx = int.Parse(Console.ReadLine()!);
int by = int.Parse(Console.ReadLine()!);
int bz = int.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow((bx-ax),2)+Math.Pow((by-ay),2)+Math.Pow((bz-az),2));
Console.WriteLine($"Расстояние = {ab:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23. Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int index = 1;
while (index <= num)
{
Console.Write($"{Math.Pow(index, 3)} ");
index++;
}
