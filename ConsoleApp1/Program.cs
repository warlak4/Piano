using System.Media;
Console.WriteLine("Переключение между октавами F2 F3 F4 F5 F6 F7 F8 F9");
Console.WriteLine("Субконтроктавы нет всвязи с её низкой герцовкой из-за которой вылетает программа");
Console.WriteLine("Изначально стоит 5 октава");
Console.WriteLine("Белые клавишы - символы от a по j"); 
Console.WriteLine("Чёрные клавишы - символы от q по t ");
Console.WriteLine("Esc - Выход"); 

ConsoleKeyInfo key = Console.ReadKey();
void hz(int hz)
{
    Console.Beep(hz, 150);
}
int[] Octa(int oct)
{
    int[] KontrOctava = new int[] { 37, 37, 37, 38, 41, 43, 46, 48, 51, 55, 58, 61 };
    int[] BolshayaOktava = new int[] { 65, 69, 73, 77, 82, 87, 92, 97, 103, 110, 116, 123 };
    int[] MalenkayOctava = new int[] { 130, 138, 146, 155, 164, 174, 184, 195, 207, 220, 233, 246 };
    int[] perv = new int[] { 261, 277, 293, 311, 329, 349, 369, 391, 415, 440, 456, 493 };
    int[] vtor = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
    int[] tret = new int[] { 1046, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    int[] chet = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

    if (oct == 3)
    {
        return BolshayaOktava;
    }
    else if (oct == 4)
    {
        return MalenkayOctava;
    }
    else if (oct == 5)
    {
        return perv;
    }
    else if (oct == 6)
    {
        return vtor;
    }
    else if (oct == 7)
    {
        return tret;
    }
    else if (oct == 8)
    {
        return chet;
    }
    return perv;
}
ConsoleKeyInfo key1; int[] oct = Octa(5);
do
{
    key1 = Console.ReadKey(true);

    switch (key1.Key)
    {
        case ConsoleKey.F2: oct = Octa(2); break;
        case ConsoleKey.F3: oct = Octa(3); break;
        case ConsoleKey.F4: oct = Octa(4); break;
        case ConsoleKey.F5: oct = Octa(5); break;
        case ConsoleKey.F6: oct = Octa(6); break;
        case ConsoleKey.F7: oct = Octa(7); break;
        case ConsoleKey.F8: oct = Octa(8); break;
        case ConsoleKey.F9: oct = Octa(9); break;
        case ConsoleKey.A:
            if (oct != Octa(2))
            {
                hz(oct[0]);
            }
            break;
        case ConsoleKey.Q:
            if (oct != Octa(9) && oct != Octa(2))
            {
                hz(oct[1]);
            }
            break;
        case ConsoleKey.S:
            if (oct != Octa(9) && oct != Octa(2))
            {
                hz(oct[2]);
            }
            break;
        case ConsoleKey.W:
            if (oct != Octa(9))
            {
                hz(oct[3]);
            }
            break;
        case ConsoleKey.D:
            if (oct != Octa(9))
            {
                hz(oct[4]);
            }
            break;
        case ConsoleKey.F:
            if (oct != Octa(9))
            {
                hz(oct[5]);
            }
            break;
        case ConsoleKey.E:
            if (oct != Octa(9))
            {
                hz(oct[6]);
            }
            break;
        case ConsoleKey.G:
            if (oct != Octa(9))
            {
                hz(oct[7]);
            }
            break;
        case ConsoleKey.R:
            if (oct != Octa(9))
            {
                hz(oct[8]);
            }
            break;
        case ConsoleKey.H:
            if (oct != Octa(9))
            {
                hz(oct[9]);
            }
            break;
        case ConsoleKey.T:
            if (oct != Octa(9))
            {
                hz(oct[10]);
            }
            break;
        case ConsoleKey.J:
            if (oct != Octa(9))
            {
                hz(oct[11]);
            }
            break;
    }
} while (key1.Key != ConsoleKey.Escape);

