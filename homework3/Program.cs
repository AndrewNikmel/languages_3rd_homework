// Использовать строки и массивы запрещено!

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num){
    int a = num%10;
    int b = (num - a)%10;
    int c = (num - b)%10;
    int d = (num - c)%10;
    int e = (num - num%10000)/10000;
    if (a == e && b == d)
        Console.WriteLine($"The number {num} is Palindrom");
    else
        Console.WriteLine($"The number {num} is not a Palindrom");
}
Console.WriteLine("Imagine and enter the number between 9999 and 100000");
int nummy = Convert.ToInt32(Console.ReadLine());
Palindrom(nummy);





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// double FindDistance(int xa, int ya, int za, int xb, int yb, int zb){
//     double distance = Math.Sqrt((xb - xa)*(xb - xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
//     return distance;
// }
// Console.Write("Enter coordinate x of point A: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y of point A: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z of point A: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate x of point B: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate y of point B: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate z of point B: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// double res = FindDistance(xa, ya, za, xb, yb, zb);
// Console.WriteLine($"Result is {Math.Round(res,2)}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void IceCube(int num){
//     for (int count = 1; count <= num; count = count + 1){
//         Console.Write(count * count * count + " ");
//         }
// }
// Console.WriteLine("Enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// IceCube(number);