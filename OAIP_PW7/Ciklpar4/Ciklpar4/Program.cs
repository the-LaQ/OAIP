int n,s,p;
Console.WriteLine("ЗНАЧ n");
n = Convert.ToInt32(Console.ReadLine());
s = 0;
p = 1;
for (int i = 0; i < n; i++)
{
    s += p;
    p += 2;

}
Console.WriteLine("Сумма последовательности");
Console.WriteLine(s);
