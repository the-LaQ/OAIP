try
{
    Console.WriteLine("Введите первое предложение:");
    string Pred1 = Console.ReadLine();

    Console.WriteLine("Введите второе предложение:");
    string Pred2 = Console.ReadLine();

    char[] Sim = { ' ', ',', '.', '!', '?', ':', ';' };

    string[] SplitPred1 = Pred1.Split(Sim, StringSplitOptions.RemoveEmptyEntries);
    string[] SplitPred2 = Pred2.Split(Sim, StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[SplitPred2.Length];
    int count = 0;
    int count2 = 0;

    foreach (string c in SplitPred1)
    {
        foreach (string s in SplitPred2)
        {

            if (c.ToLower() == s.ToLower()) count++;
            if (count == 1)
            {
                Console.WriteLine("Повторяются в 2ух предложениях такие слова как");
                count++;
            }
            if (c.ToLower() == s.ToLower())
            {
                bool a = false;
                for (int i = 0; i < result.Length - 1; i++)
                {
                    if (result[i] == s.ToLower())
                    {
                        a = true;
                        break;
                    }
                }
                if (!a)
                {
                    result[count2] = s.ToLower();
                    count2++;

                }


            }

        }
    }
    Array.Resize(ref result, count2);
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine(result[i]);
    }
    if (count2 == 0) Console.WriteLine("Слова не повторяются");
}
catch(Exception e) {
    Console.WriteLine(e.Message);
}
