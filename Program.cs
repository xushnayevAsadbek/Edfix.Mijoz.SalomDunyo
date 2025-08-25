// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{
    checkAge(20);

    try
    {
        int[] days = { 5, 8, 10, 12 };
        Console.WriteLine(days[3]);
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Dasturning ishlash davomida kutilmagan xatolik berdi: {ex.Message}");
    }
    static void checkAge(int age)
    {
        if (age < 18)
            throw new Exception("Siz 18 yoshdan kichik ekansiz");
        else
        {
            Console.WriteLine("Tizimga xush kelibsiz");
        }

    }
}

