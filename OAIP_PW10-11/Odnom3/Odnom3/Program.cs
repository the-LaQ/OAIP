int n;
Console.WriteLine("Сколько эл в масиве");
n = Convert.ToInt32(Console.ReadLine());
double[] a = new double[n];
Random and = new Random();
Console.WriteLine("Первончальный масив");
for (int i = 0; i < n; i++)
{
    a[i] = and.Next(-10, 10);
    Console.Write("\t" + a[i]);
}
for (int i = 0; i < n; i++)
{
    if (a[i] < 0)
    {
        a[i]=Math.Pow(a[i], 2);
    }
}
Array.Sort(a);
Console.WriteLine("\nНовый масив");
foreach (int i in a)   
{
    Console.Write("\t" + i);
}