while (true)
{
    double fact, n, factorial, i, x, y;
    n = Convert.ToDouble(Console.ReadLine());
    x = Convert.ToDouble(Console.ReadLine());
    i = 1;
    y = 1;
    if (n > 0)
    {
        while (n >= i)
        {
            fact = 2 * i;
            factorial = 1;
            while (fact > 0)
            {
                factorial *= fact;
                fact--;
            }
            y += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / factorial;
            i++;
        }
        Console.WriteLine(y);
    }
    else
    {
        Console.WriteLine("n не может быть меньше 1");
    }
}
