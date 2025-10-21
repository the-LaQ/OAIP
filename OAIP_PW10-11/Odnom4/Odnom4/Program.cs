try
{
    Console.WriteLine("Сколько эл в масиве");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0)
    {
        Console.WriteLine("Количество элементов должно быть больше нуля.");
        return;
    }

    int[] a = new int[n];
    Random and = new Random();

    Console.WriteLine("Первончальный масив");
    for (int i = 0; i < n; i++)
    {
        a[i] = and.Next(0, 31);
        Console.Write("\t" + a[i]);
    }

    int p;
    bool k;
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
        n--;
    } while (k);

    Console.WriteLine("\nBubble sort");
    foreach (int i in a)
    {
        Console.Write("\t" + i);
    }
}
catch(FormatException)
{
    Console.WriteLine("Ошибка ввода! Нужно вводить целое число.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

