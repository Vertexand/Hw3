// Homework 3, Задача 23 Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27 ^ 5 -> 1, 8, 27, 64, 125. 
// Console.WriteLine("Введите N");
// int N  = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <=N; i++)
// {
//    Console.Write(i*i*i + " ");// + " " - отделяет числа друг от друга
// }

Console.WriteLine("Введите число: ");  //работ. 14.37
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <=N)
{
    double res = Math.Pow (i, 3);
    Console.WriteLine(res);
    i++;
}


// ceminar 3 Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25.; 2 -> 1,4; Math.Pow (1, n степень)
// Console.WriteLine("Введите N");// Работает, ну супер, можно учиться
// int N  = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <=N; i++)
// {
//    Console.Write(i*i + " ");
// }