////////Задача 1: Задайте значения M и N.
///Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
///Использовать рекурсию, не использовать циклы.
///
void PrintNumbers(int M, int N)
{
if (M <= N)
{
Console.Write(M + " ");
PrintNumbers(M + 1, N);
}
}

Console.WriteLine("Задайте число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}: ");
PrintNumbers(M, N);
