Console.WriteLine("Введи количество эл в масиве на одной строке");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[n,n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = rnd.Next(-20,20);
        Console.Write($"\t {arr[i, j]}");
    }
    Console.WriteLine();
}

int s = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i >= j)
        {
            s += arr[i, j];
            Console.Write(arr[i, j]+" ");
        }
    }
    
}
Console.WriteLine();
Console.WriteLine("\tСумма нужных элементов");
Console.WriteLine(s);