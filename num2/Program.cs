// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = InputNumbers("Введите число M: ");
int N = InputNumbers("Введите число N: ");
int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);

void PrintSumm(int M, int N, int sum)
{
  sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов --> {sum} ");
    return;
  }
  PrintSumm(M, N - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int exit = Convert.ToInt32(Console.ReadLine());
  return exit;
}