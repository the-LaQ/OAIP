try
{
    string[] people = {
    "Иванов Сергей",
    "Иванов Артем",
    "Иванов Светлана",
    "Иванова Софья",
    "Ильин Степан",
    "Ильина Софья",
    "Иванченко Никита",
    "Иванова Николай",
    "Петров Андрей",
    "Петров Алексей",
    "Петрова Анастасия",
    "Павлова Анастасия",
    "Сидоров Павел",
    "Сидорова Полина",
    "Смирнов Сергей",
    "Смирнова Светлана",
    "Кузнецов Кирилл",
    "Кузнецова Ксения",
    "Кузьмин Кирилл",
    "Кузьмина Ксения",
    "Морозов Максим",
    "Морозова Мария",
    "Фёдоров Фёдор",
    "Фёдорова Фаина",
    "Григорьев Глеб",
    "Григорьева Галина",
    "Николаев Николай",
    "Николаева Наталья",
    "Соколов Сергей",
    "Соколова Светлана",
    "Орлов Олег",
    "Орлова Ольга",
    "Васильев Виктор",
    "Васильева Виктория",
    "Зайцев Захар",
    "Зайцева Зинаида",
    "Ковалёв Константин",
    "Ковалёва Ксения",
    "Лебедев Леонид",
    "Лебедева Лариса",
    "Егоров Евгений",
    "Егорова Екатерина",
    "Семенов Сергей",
    "Семенова Светлана",
    "Фролов Филипп",
    "Фролова Фаина",
    "Дмитриев Дмитрий",
    "Дмитриева Дарья",
    "Воронов Вячеслав",
    "Воронова Валентина",
    "Тихонов Тимофей",
    "Тихонова Таисия",
    "Ширяев Шамиль",
    "Ширяева Шура",
    "Романов Роман",
    "Романова Раиса"
};

    Console.WriteLine("Введите фамилию: ");
    string LastName = Console.ReadLine().Trim();

    Console.WriteLine("Введите имя: ");
    string Name = Console.ReadLine().Trim();

    char charLastName = LastName[0];
    char charName = Name[0];

    string[] filtr = new string[people.Length];
    int count = 0;
    for (int i = 0; i < people.Length; i++)
    {
        string[] res = people[i].Split();
        string peopleLastName = res[0];
        string peopleName = res[1];

        if (peopleLastName[0] == charLastName && peopleName[0] == charName)
        {
            filtr[count++] = people[i];
        }
    }


    if (count != 0) Console.WriteLine("Кто отсался:");
    for (int i = 0; i < filtr.Length; i++)
    {
        Console.WriteLine(filtr[i]);
    }


    bool found = false;
    for (int i = 0; i < count; i++)
    {
        string[] res = filtr[i].Split();
        string peopleLastName = res[0];
        string peopleName = res[1];

        if (peopleLastName == LastName && peopleName == Name)
        {
            Console.WriteLine("Пользователь найден: " + filtr[i]);
            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Пользователь не найден.");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);  
}