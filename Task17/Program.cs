// Написать программу, которая принимает на вход координаты (X, Y), X не = 0 и Y не = 0
// и выдает номер четверти плоскости этой точки
Console.WriteLine("введите коорд. т.А по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите коорд. т.А по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("т.А в I четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("т.А в II четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("т.А в III четверти");
}
else if (x>0 && y < 0)
{
    Console.WriteLine("т.А в IV четверти");
}
else
{
    Console.WriteLine("четверть т.А определить невозможно");
} 
// & - логическое И &&- если хоть одно усл ложь вычислен прекращ
//  | - ИЛИ || - или или - если хоть одно усл истина  то вычис прекращ.