int max = int.MinValue;
int n;
while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n == 0) break;
    if (n > max)
        max = n;
}
System.Console.WriteLine(max);