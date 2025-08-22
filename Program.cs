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
    Console.WriteLine(day);
}