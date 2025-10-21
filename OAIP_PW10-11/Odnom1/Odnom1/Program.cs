try
{
    int n;
    double p;
    Console.WriteLine("Сколько эл в масиве");
    n = Convert.ToInt32(Console.ReadLine());
    double[] a = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введи число в масив в позиции " + i + ":");
        a[i] = Convert.ToDouble(Console.ReadLine());
    }
    p = 1;
    for (int i = 0; i < n; i += 2)
    {
        p *= a[i];
    }
    Console.WriteLine("Произведение = " + p);
}
catch {
    Console.WriteLine("Ошибка");
}
