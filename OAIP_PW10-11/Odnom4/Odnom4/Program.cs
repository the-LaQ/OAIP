try
{
    int n, p;
    bool k;
    Console.WriteLine("Сколько эл в масиве");
    n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    Random and = new Random();
    Console.WriteLine("Первончальный масив");
    for (int i = 0; i < n; i++)
    {
        a[i] = and.Next(-90, 31);
        Console.WriteLine("\t" + a[i]);
    }
    do
    {
        k = false;
        for (int i = 1; i < n; i++)
        {
            if (a[i - 1] < a[i])
            {
                p = a[i];
                a[i] = a[i - 1];
                a[i - 1] = p;
                k = true;
            }
        }
    } while (k);

    Console.WriteLine("Bubble sort");
    foreach (int i in a)
    {
        Console.WriteLine("\t" + i);
    }
}
catch
{
    Console.WriteLine("Ошибка");
}

