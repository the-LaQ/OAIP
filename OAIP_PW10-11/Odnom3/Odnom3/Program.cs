try
{
    Console.WriteLine("Сколько эл в масиве");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Количество элементов должно быть больше нуля.");
        return;
    }

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
            a[i] = Math.Pow(a[i], 2);
        }
    }

    Array.Sort(a);

    Console.WriteLine("\nНовый масив");
    foreach (double i in a)
    {
        Console.Write("\t" + i);
    }
}
catch (FormatException)
{
    Console.WriteLine("Ошибка ввода! Нужно вводить целое число.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
