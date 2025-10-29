Console.WriteLine("Знчаение n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Знчаение m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[n, m];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = rnd.Next(0, 6);
        Console.Write($"\t {arr[i, j]}");
    }
    Console.WriteLine();
}

bool found = false;
for (int i = 0; i < n; i++)
{
    int min = arr[i, 0];
    int col = 0;
    for (int j = 1; j < m; j++)
    {
        if (arr[i, j] < min)
        {
            min = arr[i, j];
            col = j;
        }
    }

    bool isSaddle = true;
    for (int k = 0; k < n; k++)
    {
        if (arr[k, col] > min)
        {
            isSaddle = false;
            break;
        }
    }

    if (isSaddle)
    {
        Console.WriteLine($"Седловая точка: A[{i + 1},{col + 1}] = {min}");
        found = true;
    }
}

if (!found)
{
    Console.WriteLine("Седловых точек нет");
}