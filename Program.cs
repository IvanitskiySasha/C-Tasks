// // Напишите программу, которая на вход принимает два целых числа и проверяет, 
// // является ли первое число квадратом второго.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// // int.Parse("6546161");
// // Convert.ToInt32("1125546");
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// // if(number1 == number2 * number2)
// // {
// //     Console.WriteLine("Да");
// // }
// // else
// // {
// //     Console.WriteLine("Нет");
// // }


// if(number1 == Math.Pow(number2,2))
// {
//     Console.WriteLine($"Квадрат числа {number2} равен {number1}");
// }
// else
// {
//     Console.WriteLine("Квадрат числа {1} НЕ равен {0}", number1, number2);
// }

// // Console.WriteLine("Значение переменной number1 равно " + number1 + "vxvxv");

// 20:44
// if(number1 == Math.Pow(number2,2)) Console.WriteLine($"Квадрат числа {number2} равен {number1}");

// else Console.WriteLine("Квадрат числа {1} НЕ равен {0}", number1, number2);


//Задача1
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// // int.Parse("12345");
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());

// if(number1 == number2 * number2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// if(number1 == Math.Pow(number2,2))
// {
//     Console.WriteLine($"Квадрат числа {number2} равен {number1}");
// }
// else
// {
//     Console.WriteLine("Квадрат числа числа {1} НЕ равен {0}", number1, number2);
// }

// // Console.WriteLine("Значение переменной number1 равно",number1,трям);

// Задача 2
// Напишите программу, которая на вход принимает целое число N, а на выходе
// показывает все целые числа в промежутке от -N до N.

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//   num = num*(- 1);
// }
// int index = - num;
// while (index <= num)
// {
//   Console.Write($"{index} ");
//   index++;
// }

// Задача 3
// Напишите программу, которая принимает на вход трёхзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа.

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// while (true)
// {
//     if ((num <= 999) && (num >= 100)) break;
//     Console.WriteLine("Введено НЕ трехзначное число: ");
//     Console.Write("Введите трехзначное число: ");
//     num = Convert.ToInt32(Console.ReadLine());

// }

// int num1 = num % 10;
// int num2 = num / 100;

// Console.WriteLine($"Сумма {num1} и {num2} равна {num1 + num2}");


// int num3 = num / 10 % 10;
// Console.WriteLine(num3);

// int num = new Random().Next(100, 1000);

// int num1 = num % 10;
// int num2 = num / 100;

// Console.WriteLine($"Число {num}. Сумма {num1} и {num2} равна {num1 + num2}");

// 123 % 10 -> 3
// 123 % 100 -> 23

Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine()!;
Console.WriteLine(Convert.ToInt32(Convert.ToString(num[0])) +
                    Convert.ToInt32(Convert.ToString(num[2])));