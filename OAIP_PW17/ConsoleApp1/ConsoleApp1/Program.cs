

StreamWriter sw = new StreamWriter("Text1.txt");
sw.Write("Apple banana");
sw.WriteLine("Дан файл, содержащий текст на русском языке, и дана некторая буква.");
sw.WriteLine("Подсчитать, сколько слов начинается с указаной буквы.");
sw.Close();
StreamReader sr = new StreamReader("Text1.txt");
string s = sr.ReadToEnd();
int count = 0;
string[] arr = s.Split(' ');

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i][0] == 'с')
    {
        count++;
        Console.WriteLine(arr[i]);
    }
}
Console.WriteLine($"count = {count}");
Console.ReadKey();
