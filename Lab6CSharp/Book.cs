using System;

// Інтерфейс Видання
interface IVidannya
{
    void DisplayInfo(); // вивести інформацію про видання
    bool IsAuthor(string authorLastName); // перевірити, чи є автор видання з вказаним прізвищем
}

// Клас Книга
class Book : IVidannya
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string authorLastName, int year, string publisher)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Year = year;
        Publisher = publisher;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {AuthorLastName}, Рік видання: {Year}, Видавництво: {Publisher}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас Стаття
class Article : IVidannya
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string Journal { get; set; }
    public int IssueNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string authorLastName, string journal, int issueNumber, int year)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Journal = journal;
        IssueNumber = issueNumber;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Стаття: {Title}, Автор: {AuthorLastName}, Журнал: {Journal}, Номер: {IssueNumber}, Рік видання: {Year}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас ЕлектроннийРесурс
class ElectronicResource : IVidannya
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string Link { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string authorLastName, string link, string annotation)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Link = link;
        Annotation = annotation;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Електронний ресурс: {Title}, Автор: {AuthorLastName}, Посилання: {Link}, Анотація: {Annotation}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName.Equals(authorLastName, StringComparison.OrdinalIgnoreCase);
    }
}


