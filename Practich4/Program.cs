static void Menu()
{
    Console.WriteLine("  Вы выбрали дату: 15.10.23");
    Console.WriteLine("  1.Приехать с дачи");
    Console.WriteLine("  2.Убраться в квартире");
}
static void Menu2()
{
    Console.WriteLine("  Вы выбрали дату: 14.10.23");
    Console.WriteLine("  1.Поехать на дачу");
    Console.WriteLine("  2.Сходить в магазин");
}
static void Menu3()
{
    Console.WriteLine("  Вы выбрали дату: 16.10.23");
    Console.WriteLine("  1.Сделать уроки");
}
static void in1(int pos)
{
    if (pos == 1)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Приехать с дачи");
        Console.WriteLine("--------------------");
        Console.WriteLine("Описание: Электричка в 14:00");
        Console.WriteLine("Дата: 15.10.2023 14:00");
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
    else if (pos == 2)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Убраться в квартире");
        Console.WriteLine("--------------------");
        Console.WriteLine("Описание: Пропылесосить, помыть полы");
        Console.WriteLine("Дата: 15.10.2023 17:00");
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}
static void in2(int pos)
{
    if (pos == 1)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Поехать на дачу");
        Console.WriteLine("--------------------");
        Console.WriteLine("Описание: Автобус в 9:00");
        Console.WriteLine("Дата: 14.10.2023 9:00");
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
    else if (pos == 2)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Сходить в магазин");
        Console.WriteLine("--------------------");
        Console.WriteLine("Описание: Купить картошку, молоко, хлеб");
        Console.WriteLine("Дата: 14.10.2023 12:00");
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}
static void in3(int pos)
{
    if (pos == 1)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Сделать уроки");
        Console.WriteLine("--------------------");
        Console.WriteLine("Описание: Математика, БЖД, ИТ");
        Console.WriteLine("Дата: 16.10.2023 18:00");
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }

}

static void k1()
{
    Menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    while (key.Key != ConsoleKey.Escape)
    {



        key = Console.ReadKey();
        int pos = 1;

        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.RightArrow)
            {

                Console.Clear();
                k3();



            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                k2();


            }
            if (key.Key == ConsoleKey.UpArrow && pos != 1)
            {
                pos--;
            }
            else if (key.Key == ConsoleKey.DownArrow && pos != 2)
            {
                pos++;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        in1(pos);
        Menu();
    }
}
k1();
static void k3()
{
    Menu3();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    while (key.Key != ConsoleKey.Escape)
    {



        key = Console.ReadKey();
        int pos = 1;

        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.RightArrow)
            {

                Console.Clear();
                k2();



            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                k1();


            }
            if (key.Key == ConsoleKey.UpArrow && pos != 1)
            {
                pos--;
            }
            else if (key.Key == ConsoleKey.DownArrow && pos != 1)
            {
                pos++;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        in3(pos);
        Menu3();

    }
}
static void k2()
{
    Menu2();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    while (key.Key != ConsoleKey.Escape)
    {



        key = Console.ReadKey();
        int pos = 1;

        while (key.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.RightArrow)
            {

                Console.Clear();
                k1();



            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                k3();


            }
            if (key.Key == ConsoleKey.UpArrow && pos != 1)
            {
                pos--;
            }
            else if (key.Key == ConsoleKey.DownArrow && pos != 2)
            {
                pos++;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        in2(pos);
        Menu2();

    }
}