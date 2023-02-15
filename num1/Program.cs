// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"




void EvenNumbers(int M, int N)
{
    if (M <= N)
    {
        if (M % 2 == 0 & M != 0)
        {
            System.Console.WriteLine($"{M}\t");
        }
        EvenNumbers(M + 1, N);
    }
}
EvenNumbers(1, 5);