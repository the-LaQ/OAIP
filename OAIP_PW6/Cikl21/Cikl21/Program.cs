int r, x, y,n;
double x_n,y_n;
r = Convert.ToInt32(Console.ReadLine());
x_n = 1;
y_n = 1;
n = 1;
do
{
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    x_n = Math.Sqrt((r * r) - ((y - r) * (y - r))) - r;
    y_n = Math.Sqrt((r * r) - ((x + r) * (x + r))) + r;
    if ((x <= x_n) && (y <= y_n))
    {
        Console.WriteLine("попал");
    }
    else
    {
        Console.WriteLine("не попал");
    }
    n++;
} while (n <= 3);