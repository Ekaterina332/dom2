// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 5)
    Console.Write("будний день");
else if (n == 6 || n == 7)
    Console.Write("выходной");
else 
    Console.Write("Вы ввели число не от 1 до 7");