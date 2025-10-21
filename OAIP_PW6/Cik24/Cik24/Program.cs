int x,sum;
sum = 1;
x = Convert.ToInt32(Console.ReadLine());
do{
    sum *= x;
    x -= 2;
} while(x >= 2);
Console.WriteLine(sum);