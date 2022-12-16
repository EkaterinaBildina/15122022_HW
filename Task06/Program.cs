// Напишите программу, которая 
// на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Please, input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int balance = (number % 2);

if (balance == 0)
{
    Console.WriteLine("Yes");
}
else 
Console.WriteLine("No");