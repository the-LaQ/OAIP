try
{

    int n;
    Console.WriteLine("Сколько эл в масиве");
    n = Convert.ToInt32(Console.ReadLine());
    double[] a = new double[n];
    Random and = new Random();
    for (int i = 0; i < n; i++)
    {
        a[i] = and.Next(-10, 10);
        Console.WriteLine("\t" + a[i]);
    }
    double s;
    int p1, p2;
    s = 0;
    p1 = 0;
    p2 = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] > 0)
        {
            p1 = i;
            Console.WriteLine("Второй положительный эл:" + a[i]);
            break;
        }
    }
    for (int i = p1 + 1; i < n; i++)
    {
        if (a[i] > 0)
        {
            p2 = i;
            Console.WriteLine("Первый положительный эл:" + a[i]);
            break;
        }
    }
    for (int i = p1 + 1; i < p2; i++)
    {
        s += a[i];
    }
    Console.WriteLine("Сумма между эл:" + s);
}
catch
{
    Console.WriteLine("Ошибка");
}
