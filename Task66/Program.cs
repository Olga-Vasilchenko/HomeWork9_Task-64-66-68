// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите первое число");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numb2 = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if(m == n) return n;
    return SumNumbers(m + 1, n) + m;
}
int sum = SumNumbers(numb1, numb2);
Console.WriteLine($"Сумма натуральных элементов = {sum}");