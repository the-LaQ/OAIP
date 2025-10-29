Console.WriteLine("Матрица n m");
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

int ks = 0;
for (int i = 0; i < n; i++)
{
    int k = 0;
    for (int j = 0; j < m; j++)
    {
        if(arr[i,j]!=0){
            k++;
        }
        else
        {
            break;
        }
    }
    if (k == m)
    {
        ks++;
    }
}
Console.WriteLine($"Количество строк без нулей: {ks}");

int[] count = new int[6];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        count[arr[i, j]]++;
    }
}
int maxRepeat = -1;
for (int i = 0; i < count.Length; i++)
{
    if (count[i] > 1) 
    {
        maxRepeat = i; 
    }
}


if (maxRepeat != -1)
    Console.WriteLine($"Максимальное число, встречающееся более одного раза: {maxRepeat}");
else
    Console.WriteLine("Нет чисел, встречающихся более одного раза.");

