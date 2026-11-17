using System;

class Motor
{
    public string Model { get; set; }
    public int BeygirGucu { get; set;}

    public Motor(string model, int beygirGucu)
    {
        Model = model;
        BeygirGucu = beygirGucu;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} motor calisiyor.");
    }
}

class Araba
{
    public string Marka { get; set; }
    private Motor arabaMotoru;

    public Araba(string marka, string motorModeli, int beygirGucu)
    {
        Marka = marka;
        arabaMotoru = new Motor(motorModeli, beygirGucu);
    }

    public void Ac()
    {
        Console.WriteLine($"{Marka} araba aciliyor.");
        arabaMotoru.Calistir();
    }
}

class Program
{
    static void Main()
    {
        Araba araba = new Araba("ford","a123",500);
        araba.Ac();
    }
}