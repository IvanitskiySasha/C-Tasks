// Напишите программу, которая выводит третью слева цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// num < 100 -> третьей цифры нет
// num = 5789 -> /10 -> 578

int num2 = 0;

if(num < 0) num = -num; //если число отрицательное

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");

}
else
{
    while (num > 999) //(num > 100)
    {
        //num2 = num % 10;
        num /= 10; // num = num / 10
    }
    Console.WriteLine(num);
    num2 = num % 10;
    Console.WriteLine(num2);
}
// Console.Write("Введите число: ");
// string num = Console.Readline()!;
// if (num.Length < 3)
//{
    //Console.WriteLine("третьей цифры нет");
//}
//else
// {
    //Console.WriteLine(num[2]);

// }