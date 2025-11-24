using System.Text;



string[] products =
{
    "keyboards",
    "mouse",
    "monitor",
    "headset",
    "USB"
};
decimal[] price =
{
    100.5m,
    30.7m,
    345.3m,
    60m,
    0.5m
};


StringBuilder sb = new StringBuilder();
sb.Append("=== Продажи за день ===\n\n");
sb.AppendLine("<-- Списочек -->\n");
sb.EnsureCapacity(500);
for (int i = 0;i< products.Length; i++)
{
    sb.AppendFormat("{0}) {1,-15} {2,8}$\n", i + 1, products[i], price[i]);
}

sb.Insert(sb.Length-1, "\n\nДатта отчета: " + DateTime.Now );

string result = sb.ToString();
Console.WriteLine(
result);

char [] chars = new char[34];
sb.CopyTo(sb.Length - 34, chars, 0, 34);

sb.Replace("<-- Списочек -->\n", "<-- Список -->\n");
sb.Remove(sb.Length - 36, 36);
sb.AppendLine();
result = sb.ToString();
Console.WriteLine(result);


sb.Clear();
sb.Append("ОШИБКА");
result = sb.ToString();
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine(new string(chars));