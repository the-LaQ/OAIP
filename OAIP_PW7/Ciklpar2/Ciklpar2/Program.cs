Console.WriteLine("Что хочешь нарисовать?");
Console.WriteLine("1) треугольник");
Console.WriteLine("2) елка ");
Console.WriteLine("3) квадрат");


string name = Console.ReadLine();
if (name == "1")
{
    for (int i = 0, height = 10; i < height; i++)
    {
        for (int s = 0; s < height - i - 1; s++)
        {
            Console.Write(' ');
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

else if (name == "2")
{
    int height = 10;
    for (int i = 0; i < height; i++)
    {
        for (int s = 0; s < height - i - 1; s++)
        {
            Console.Write(' ');
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

    }
    for (int s = 0; s < 4; s++)
    {
        for (int d = 0; d < 6; d++)
        {
            Console.Write(" ");
        }
        for (int d = 0; d < 6; d++)
        {
            Console.Write("*");

        }
        Console.WriteLine();

    }
}
else if (name == "3")
{
    for (int i = 0; i <= 10; i++)
    {
        for (int s = 0; s <= 23; s++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Такого нет");
}