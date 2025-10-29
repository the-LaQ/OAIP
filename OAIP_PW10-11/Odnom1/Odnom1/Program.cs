try
{
    Console.Write("Сколько элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Количество элементов должно быть больше нуля.");
        return;
    }

    double[] a = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число для позиции {i}: ");
        a[i] = Convert.ToDouble(Console.ReadLine());
    }

    double sum = 1;
    for (int i = 0; i < n; i += 2) 
        sum *= a[i];

    Console.WriteLine($"\nПроизведение элементов с чётными индексами = {sum}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: нужно вводить только числа.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
