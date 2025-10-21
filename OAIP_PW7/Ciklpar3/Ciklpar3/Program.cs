Random a = new Random();
int x = a.Next(1, 11);
for (int i = 4, number = 0; i >= 0 && number != x; i--)
{
    Console.WriteLine("угадай загаданное число");
    number = Convert.ToInt32(Console.ReadLine());
    string p = number == x ? "Угадал число" : number > x ? "Мое число меньше" : "Мое число больше";
    Console.WriteLine(p);
    Console.WriteLine("У тебя осталось " + i + " попыток");
}