/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

int f(int m, int n)
{
  if (m == 0)
    return n + 1;
  else if (m > 0 && n == 0)
    return f(m - 1, 1);
    else
    return f(m - 1, f(m, n - 1));
}
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n,m));