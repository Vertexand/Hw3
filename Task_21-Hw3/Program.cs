// Homework 3 Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84 , A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("введите радиус-вектор 1-й т.(x1, y1, z1) через enter "); // 
int x1  = Convert.ToInt32(Console.ReadLine());
int y1  = Convert.ToInt32(Console.ReadLine());
int z1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите радиус-вектор 2-й т. (x2, y2, z2) через enter ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt (Math.Pow(x1-x2 ,2) + Math.Pow(y1-y2, 2)+ Math.Pow(z1-z2, 2));
Console.WriteLine($"{res:f2}");

// seminar 3 Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21

// double n = Math.Sqrt(25);// корень из n, в перемен n положить корень из 25/ int не годится мало
// n = Math.Pow(n, 2); // возвед числа в степень 2
// Console.WriteLine(n);

// Console.WriteLine("введите коорд. х т.А");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите коорд. y т.А");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите коорд. х т.B");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите коорд. y т.B");
// int yb = Convert.ToInt32(Console.ReadLine());
// double res = Math.Sqrt (Math.Pow(xa-xb ,2) + Math.Pow(ya-yb,2));

// // Console.WriteLine(res); //1 way
// Console.WriteLine($"{res:f2}");//  2 way округл до 2 знаков после запят use!!!!
// res = Math.Round(res, 2);//3 way тоже
// Console.WriteLine($"{res}");
