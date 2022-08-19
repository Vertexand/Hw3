// Homework 3 Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. 14212 -> нет; 12821 -> да; 23432 -> да

Console.Write("Введите число: ");// работает
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"{number} - палиндром.");
  }
  else Console.WriteLine($"{number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите пятизначное число");
// //sssssssssssssssssssssssssssss

// Console.WriteLine("Введите N"); // задача 19 полиндром, условие не работает,
// int N = Convert.ToInt32(Console.ReadLine());
// if (N<10000 || N> 100000)
// {
//     Console.WriteLine("Введите пятизначное число ");
// }
// else (N /= 10000 == N %= 10 && N /= 1000 == N %=100);
// {
//     Console.WriteLine($"число: {N} - палиндром.");
//   }

//sssssssssssssssssssssssssssssssssssssssss

// seminar 3 Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("введите номер четверти");
// int x  = Convert.ToInt32(Console.ReadLine());// х можно заменить quarter
// if (x == 1)
// {
//     Console.WriteLine("т.А x > 0 & y > 0");
// }
// else if (x == 2)
// {
//     Console.WriteLine("x < 0 & y > 0");
// }
// else if (x == 3)
// {
//     Console.WriteLine("x < 0 & y < 0");
// }
// else if (x == 4)
// {
//     Console.WriteLine("x>0 & y < 0");
// }
// else
// {
//     Console.WriteLine("нет такой четверти");}

// enum Quarter{ //перечисл объект 
//     First =1;
//     Second =2;
//     Third = 3;
//     Fourth = 4;
// }