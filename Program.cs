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

// int a = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// double s = 0;

// for (int i = 0; i <= n; i++)
// {
//     s = s + Math.Pow(a, i);
// }
// System.Console.WriteLine(s);

//Task3

// int a;
// int s = 0;
// int b = -1;

// while (true)
// {
//     a = int.Parse(Console.ReadLine());
//     if (a == 0 && b == 0)
//     {
//         break;
//     }
//     else
//     {
//         b = a;
//         s = s + a;
//     }
// }
// System.Console.WriteLine(s);

//Task4
// int a = int.Parse(Console.ReadLine());
// int ctn = 0;
// int[] mas = new int[a];
// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 1; i < mas.Length; i++)
// {
//     if (mas[i] > 0 && mas[i - 1] > 0 || mas[i] < 0 && mas[i - 1] < 0)
//     {
//         ctn++;
//     }
// }
// if (ctn == 0) System.Console.WriteLine("NO");
// else System.Console.WriteLine("YES");

//task5

// int a = int.Parse(Console.ReadLine());
// int[] mas = new int[a];

// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(mas);
// for (int i = 1; i < mas.Length; i++)
// {
//     if (mas[i] == mas[i - 1])
//     {
//         System.Console.Write($"{mas[i]} {mas[i - 1]} ");
//     }
// }

//task6

// int a = int.Parse(Console.ReadLine());
// int[] mas = new int[a];

// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(mas);
// System.Console.WriteLine(mas[0]);

//task7

// int s = 0;
// int n;
// int ctn = 0;
// while (true)
// {
//     System.Console.WriteLine("Give a number:");
//     n = int.Parse(Console.ReadLine());
//     if (n == 0) break;
//     ctn++;
//     s = s + n;
// }
// System.Console.WriteLine($"Sum of numbers: {s}");
// System.Console.WriteLine($"Count of numbers: {ctn}");

//task8

// int a = int.Parse(Console.ReadLine());
// int sum = 0;
// int pum = 1;
//     a = Math.Abs(a);

//     while (a > 0)
//     {
//         sum += a % 10;
//     pum *= a % 10; 
//         a /= 10;  
//     }
// System.Console.WriteLine(sum);
// System.Console.WriteLine(pum);

//task 9

// int a = int.Parse(Console.ReadLine());
// int s = 0;
// for (int i = a; i > 0; i /= 10)
// {
//     s = s * 10 + i % 10;
// }
// System.Console.WriteLine(s);

//task10

//