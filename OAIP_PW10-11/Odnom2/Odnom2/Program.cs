//try
//{

//    int n;
//    Console.WriteLine("Сколько эл в масиве");
//    n = Convert.ToInt32(Console.ReadLine());
//    double[] a = new double[n];
//    Random and = new Random();
//    for (int i = 0; i < n; i++)
//    {
//        a[i] = and.Next(-10, 10);
//        Console.WriteLine("\t" + a[i]);
//    }
//    double s;
//    int p1, p2;
//    s = 0;
//    p1 = 0;
//    p2 = 0;
//    for (int i = 0; i < n; i++)
//    {
//        if (a[i] > 0)
//        {
//            p1 = i;
//            Console.WriteLine("Второй положительный эл:" + a[i]);
//            break;
//        }
//    }
//    for (int i = p1 + 1; i < n; i++)
//    {
//        if (a[i] > 0)
//        {
//            p2 = i;
//            Console.WriteLine("Первый положительный эл:" + a[i]);
//            break;
//        }
//    }
//    for (int i = p1 + 1; i < p2; i++)
//    {
//        s += a[i];
//    }
//    Console.WriteLine("Сумма между эл:" + s);
//}
//catch
//{
//    Console.WriteLine("Ошибка");
//}
try
{
    Console.Write("Сколько эл в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Количество элементов должно быть больше нуля.");
        return;
    }

    double[] a = new double[n];
    Random rand = new Random();

    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(-10, 10);
        Console.Write(a[i] + "\t");
    }
    Console.WriteLine();
    int firstPos = -1;
    int secondPos = -1;

    for (int i = 0; i < n; i++)
    {
        if (a[i] > 0)
        {
            if (firstPos == -1)
                firstPos = i;
            else
            {
                secondPos = i;
                break;
            }
        }
    }

    if (firstPos == -1 || secondPos == -1)
    {
        Console.WriteLine("Недостаточно положительных элементов для вычисления суммы.");
        return;
    }

    double sum = 0;
    for (int i = firstPos + 1; i < secondPos; i++)
    {
        sum += a[i];
    }

    Console.WriteLine($"Первый положительный элемент: a[{firstPos}] = {a[firstPos]}");
    Console.WriteLine($"Второй положительный элемент: a[{secondPos}] = {a[secondPos]}");
    Console.WriteLine($"Сумма элементов между ними: {sum}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка ввода! Нужно вводить целое число.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

