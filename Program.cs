//напишите программу, которая на входе принимает три числа и
// выдает максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int n3 = Convert.ToInt32(Console.ReadLine());
int maxi = n;
if (n2>maxi)
   maxi = n2;
if (n3>maxi)
   maxi = n3;
Console.WriteLine($"max = {maxi}");
