using System;
using System.Collections;

interface IUserInterface
{
    void Display();
}

interface IEmbeddedInterface
{
    void OutputDetails();
}

class Country : IUserInterface, IEnumerable
{
    public string Name { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public Country()
    {
        Console.WriteLine("Country constructor");
    }

    public Country(string name, int population, double area)
    {
        Name = name;
        Population = population;
        Area = area;
        Console.WriteLine("Country constructor with parameters");
    }

    ~Country()
    {
        Console.WriteLine("Country destructor");
    }

    protected virtual void Show()
    {
        Console.WriteLine($"Country: {Name}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Area: {Area}");
    }

    public void Display()
    {
        Show();
    }

    public IEnumerator GetEnumerator()
    {
        yield return Name;
        yield return Population;
        yield return Area;
    }
}

class Republic : Country, IEmbeddedInterface
{
    public string President { get; set; }

    public Republic()
    {
        Console.WriteLine("Republic constructor");
    }

    public Republic(string name, int population, double area, string president)
        : base(name, population, area)
    {
        President = president;
        Console.WriteLine("Republic constructor with parameters");
    }

    ~Republic()
    {
        Console.WriteLine("Republic destructor");
    }

    protected override void Show()
    {
        base.Show();
        Console.WriteLine($"President: {President}");
    }

    public void OutputDetails()
    {
        Show();
    }
}

class Monarchy : Country, IEmbeddedInterface
{
    public string Monarch { get; set; }

    public Monarchy()
    {
        Console.WriteLine("Monarchy constructor");
    }

    public Monarchy(string name, int population, double area, string monarch)
        : base(name, population, area)
    {
        Monarch = monarch;
        Console.WriteLine("Monarchy constructor with parameters");
    }

    ~Monarchy()
    {
        Console.WriteLine("Monarchy destructor");
    }

    protected override void Show()
    {
        base.Show();
        Console.WriteLine($"Monarch: {Monarch}");
    }

    public void OutputDetails()
    {
        Show();
    }
}

class Kingdom : Monarchy
{
    public int NobilityCount { get; set; }

    public Kingdom()
    {
        Console.WriteLine("Kingdom constructor");
    }

    public Kingdom(string name, int population, double area, string monarch, int nobilityCount)
        : base(name, population, area, monarch)
    {
        NobilityCount = nobilityCount;
        Console.WriteLine("Kingdom constructor with parameters");
    }

    ~Kingdom()
    {
        Console.WriteLine("Kingdom destructor");
    }

    protected override void Show()
    {
        base.Show();
        Console.WriteLine($"Nobility Count: {NobilityCount}");
    }
}
