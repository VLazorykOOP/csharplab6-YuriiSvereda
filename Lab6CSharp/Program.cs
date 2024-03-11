//// See https://aka.ms/new-console-template for more information
///// <summary>
/////  Top-level statements 
/////  Код програми (оператори)  вищого рівня
///// </summary>
/////
//Console.WriteLine("Lab6 C# ");
//AnyFunc();

///// <summary>
///// 
/////  Top-level statements must precede namespace and type declarations.
///// At the top-level methods/functions can be defined and used
///// На верхньому рівні можна визначати та використовувати методи/функції
///// </summary>
//void AnyFunc()
//{
//    Console.WriteLine(" Some function in top-level");
//}
//Console.WriteLine("Problems 1 ");
//AnyFunc();
////  приклад класів
//UserClass cl = new UserClass();
//cl.Name = " UserClass top-level ";
//User.UserClass cl2 = new();
//cl2.Name = " UserClass namespace User ";




///// <summary>
///// 
///// Top-level statements must precede namespace and type declarations.
///// Оператори верхнього рівня мають передувати оголошенням простору імен і типу.
///// Створення класу(ів) або оголошенням простору імен є закіченням  іструкцій верхнього рівня
///// 
///// </summary>

//namespace User
//{
//    class UserClass
//    {
//        public string Name { get; set; }
//        public UserClass()
//        {
//            Name = "NoName";
//        }
//        UserClass(string n)
//        {
//            Name = n;
//        }
//    }

//}
//class UserClass
//{
//    public string Name { get; set; }
//}

using System.Text;

static void Task1()
{
    Country country = new Country("USA", 328_000_000, 9_800_000);
    Republic republic = new Republic("France", 67_000_000, 640_000, "Emmanuel Macron");
    Monarchy monarchy = new Monarchy("United Kingdom", 67_000_000, 242_000, "Elizabeth II");
    Kingdom kingdom = new Kingdom("Sweden", 10_000_000, 450_000, "Carl XVI Gustaf", 1000);

    // Перевірка типів об'єктів
    Console.WriteLine("Country is a Republic: " + (country is Republic));
    Console.WriteLine("Monarchy is a Country: " + (monarchy is Country));
    Console.WriteLine("Kingdom is a Monarchy: " + (kingdom is Monarchy));
    Console.WriteLine("Republic is a Kingdom: " + (republic is Kingdom));

    //// Використання оператора as
    //Republic republicAsCountry = republic as Country;
    //Monarchy monarchyAsCountry = monarchy as Country;
    //Kingdom kingdomAsMonarchy = kingdom as Monarchy;

    //if (republicAsCountry != null)
    //    Console.WriteLine("Republic casted as Country successfully");
    //if (monarchyAsCountry != null)
    //    Console.WriteLine("Monarchy casted as Country successfully");
    //if (kingdomAsMonarchy != null)
    //    Console.WriteLine("Kingdom casted as Monarchy successfully");

    // Використання typeof
    if (typeof(Kingdom) == typeof(Monarchy))
        Console.WriteLine("Kingdom type matches Monarchy type");
    else
        Console.WriteLine("Kingdom type does not match Monarchy type");
}
static void Task2()
{
    // Створення каталогу з n видань
    IVidannya[] catalog = new IVidannya[]
    {
            new Book("Трони для богів", "Мартін", 1996, "Бантик"),
            new Article("Мистецтво письма", "Петров", "Краса мови", 3, 2020),
            new ElectronicResource("Всесвіт в кімнаті", "Сидоренко", "http://example.com", "Анотація до електронного ресурсу")
    };

    // Виведення повної інформації з каталогу
    Console.WriteLine("Повна інформація з каталогу:");
    foreach (var item in catalog)
    {
        item.DisplayInfo();
    }

    // Пошук видань за прізвищем автора
    string searchAuthor = "Мартін";
    Console.WriteLine($"\nПошук видань за автором {searchAuthor}:");
    foreach (var item in catalog)
    {
        if (item.IsAuthor(searchAuthor))
        {
            item.DisplayInfo();
        }
    }
}
static void Task3()
{
    Country country = new Country("USA", 328_000_000, 9_800_000);
    foreach(var item in country)
    {
        Console.WriteLine(item);
    }
}
static void ShowMenu()
{
    string[] menuStrings =
    {
                "1. Task 1!",
                "2. Task 2!",
                "3. Task 3!"
            };
    int currentOprtion = 0;
    ConsoleKeyInfo keyInfo;
    int choice = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Lab 5 CSharp!");
        PrintMenu(menuStrings, currentOprtion);


        keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
        {
            currentOprtion = currentOprtion + 1 <= menuStrings.Length - 1 ? currentOprtion + 1 : 0;
        }
        else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
        {
            currentOprtion = currentOprtion - 1 >= 0 ? currentOprtion - 1 : menuStrings.Length - 1;
        }
        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            choice = currentOprtion;
            break;
        }
    }
    switch (choice)
    {
        case 0:
            Console.WriteLine("Task1!");
            Task1();
            break;
        case 1:
            Console.WriteLine("Task2!");
            Task2();
            break;
        case 2:
            Console.WriteLine("Task3!");
            Task3();
            break;
        default:
            break;
    }
}
static void PrintMenu(string[] menuString, int choosenString)
{
    for (int i = 0; i < menuString.Length; i++)
    {
        if (i == choosenString)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine(menuString[i]);
        if (i == choosenString)
        {
            Console.ResetColor();
        }
    }
}

Console.OutputEncoding = Encoding.Unicode;
while (true)
{
    Console.Clear();
    ShowMenu();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

