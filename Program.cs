// int max = int.MinValue;
// int n;
// while (true)
// {
//     n = int.Parse(Console.ReadLine());
//     if (n == 0) break;
//     if (n > max)
//         max = n;
// }
// System.Console.WriteLine(max);

//Task2

int a = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double s = 0;

for (int i = 0; i <= n; i++)
{
    s = s + Math.Pow(a, i);
}
System.Console.WriteLine(s);