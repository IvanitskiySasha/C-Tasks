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








// Console.Write("Введите трехзначное число: ");
// string num = Console.ReadLine()!;
// Console.WriteLine(Convert.ToInt32(Convert.ToString(num[0])) +
//                     Convert.ToInt32(Convert.ToString(num[2])));


// Console.Write("firstNumber: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("secondNumber: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.Write("первое число больше");
// }
// else
// {
//     Console.Write("второе число больше");
// }



// Console.Write("firstNumber: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("secondNumber: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.Write("первое число больше");
// }
// if (num1 < num2)
// {
//     Console.Write("второе число больше");
// }
// if (num1 == num2)
// {
//     Console.Write("числа равны");
// }


// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//       Console.Write("firstNumber: ");
//       int num1 = Convert.ToInt32(Console.ReadLine());
//       Console.Write("secondNumber: ");
//       int num2 = Convert.ToInt32(Console.ReadLine());
//       if (num1 > num2)
//       {
//          Console.Write("первое число больше");
//       }
//       if (num1 < num2)
//       {
//          Console.Write("второе число больше");
//       }
//       if (num1 == num2)
//       {
//          Console.Write("числа равны");
//       }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 6;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }
