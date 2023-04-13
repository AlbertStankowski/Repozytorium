using KlasyAbstakcyjne.Klasy;
using System.ComponentModel;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Stozek st1 = new Stozek(2,3);
        Stozek st2 = new Stozek(3,4);
        Czworoscian cz1 = new Czworoscian(2,3);
        Czworoscian cz2 = new Czworoscian(3,4);
        Console.WriteLine(st1.Objetosc());
        Console.WriteLine(st2.Objetosc());
        Console.WriteLine(cz1.Objetosc());
        Console.WriteLine(cz2.Objetosc());
        List<Bryla> bryly = new List<Bryla>();
        bryly.Add(st1);
        bryly.Add(st2);
        bryly.Add(cz1);
        bryly.Add(cz2);
        foreach (Bryla elem in bryly)
        {
            Console.WriteLine(elem.Objetosc());
        }
    }
}