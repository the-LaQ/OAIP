try
{
    Console.WriteLine("Сколько элементов в массиве:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Количество элементов должно быть больше нуля.");
        return;
    }

    double[] a = new double[n];
    Random rnd = new Random();

    Console.WriteLine("Первоначальный массив:");
    for (int i = 0; i < n; i++)
    {
        a[i] = rnd.Next(-10, 10);
        Console.Write("\t" + a[i]);
    }
    Console.WriteLine("\n сколько\n");

    int k = Convert.ToInt32(Console.ReadLine());
    while (k > 0)
    {
    Console.WriteLine("\n Введи инд эл\n");
    int p = Convert.ToInt32(Console.ReadLine());
        n = a.Length;
    for (int i=p; i < n-1; i++)
    {
        a[i] = a[i + 1];
    }
        k--;
    }
    
    Array.Resize(ref a, n-1);
    n=a.Length;
    Console.WriteLine("\nНовый массив:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("\t" + a[i]);
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
