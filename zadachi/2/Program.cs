// Напишите программу, которая выводит третью цифру заданного числа 
//  или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else if (n >= 100 && n <= 999)
    Console.WriteLine($"Третья цифра: {n % 10}");
else
    Console.WriteLine($"Третья цифра: {(n/100) % 10}");