// א. פעולה שמחשבת את ההנחה למשפחה אחת
public static int CalculateDiscount(int People, int Students)
{
    int discount1 = 0;
    int discount2 = Students * 40;

    if (People > 6)
    {
        discount1 = 100;
    }

    if (discount1 > discount2)
    {
        return discount1;
    }
    else
    {
        return discount2;
    }
}

// ב. פעולה שמחשבת את סך כל ההנחות ביישוב מסוים
public static int CalculateTotalDiscount(int Families)
{
    int Total = 0;

    for (int i = 0; i < Families; i++)
    {
        Console.WriteLine("enter amount of people");
        int People = int.Parse(Console.ReadLine());

        Console.WriteLine("enter amount of students");
        int Students = int.Parse(Console.ReadLine());

        Total = Total + CalculateDiscount(People, Students);
    }

    return Total;
}

// ג. תכנית ראשית שבודקת אילו יישובים חרגו מהתקציב של המועצה
public static void Main()
{
    // מערך שנתון
    int[] rdc = new int[10]

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("how many familiesin town?");
        int Families = int.Parse(Console.ReadLine());

        int Total = CalculateTotalDiscount(Families);

        if (Total > rdc[i])
        {
            Console.WriteLine("town " + i + "exceeded the limit.");
        }
    }
}


