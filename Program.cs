// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNUm ( int N, int a=1)
// { 
// if (N!=a)
// { 
// if(a < N)

// {
// PrintNUm(N, a + 1);
// Console.Write(a + " " );
// }
// else Console.Write(1 +" ");
// }
// }
// PrintNUm(10);




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int count (int N, int M)
// {
// int sum = M;
// if ( N==M)
// return N;
// else 
// {
// return sum + count(N,M-1);
// }
// }
// int result = count  (1,15);
// Console.WriteLine(result);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akk ( int m, int n)
{
if (m==0)
{
return n + 1;
}
else if (n == 0)
{
return Akk(m - 1, 1);
}
else
{
return Akk(m - 1, Akk(m, n - 1));
}
}
int result = Akk(3,2);
Console.WriteLine(result);