// See https://aka.ms/new-console-template for more information
Console.WriteLine("Salom, Dunyo!");

// 2 explicit 

double change = 200.15;
int cash = (int)change;
//Console.WriteLine(cash);

//Console.WriteLine("Ismingizni kiriting:");
//string name = Console.ReadLine();
//Console.WriteLine("Yoshingiz " + name);
//Console.WriteLine("Yoshingizni  kiriting:");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine("Yoshingiz " + age);

List<string> names = new List<string> { "t" , " r " , "f" , "d"};
//Console.WriteLine(names[2]);

foreach(string name in names)
{
    //Console.WriteLine($"Salom , { name}");
}

string[] days = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };

foreach(string day in days)
{
    //Console.WriteLine(day);
}


int drinkId = 2;

while(drinkId<1 || drinkId > 4)
{
    //Console.WriteLine("Ichimlik tanlang:");
    //Console.WriteLine("1: Cola ; 2: Fanta ; 3: Sprite ; 4: Aqua");
    drinkId = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Siz {drinkId} - ichimlikni tanladingiz");

while (true)
{
    //Console.WriteLine(DateTime.Now.Second);

    if (DateTime.Now.Second % 5 == 0)
        break;
}
//long A , B ;

//A = long.Parse(Console.ReadLine());
//B = long.Parse(Console.ReadLine());
//long c = A + B;
//Console.WriteLine(c);

int rows = 10, column = 10;
for (int a = 1; a <= rows; a++)
{
    for(int b = 1 ; b <= column; b++)
    {
        Console.Write($"{b}*{a} = {(b*a)}\t");
    }
    Console.WriteLine();
}