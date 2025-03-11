using System;

class Program
{
    static void Main()
    {
        Console.Write("Boyunuzu santimetre cinsinden girin (Örn: 175): ");
        double boyCm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kilonuzu kilogram cinsinden girin (Örn: 70): ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        // Boyu metreye cevirme
        double boyMetre = boyCm / 100;

        // BMI
        double bmi = kilo / (boyMetre * boyMetre);

        // Durum
        string durum;
        if (bmi < 18.5)
            durum = "Zayıf";
        else if (bmi >= 18.5 && bmi < 24.9)
            durum = "Normal";
        else if (bmi >= 25 && bmi < 29.9)
            durum = "Fazla Kilolu";
        else
            durum = "Obez";

        // Sonuc
        Console.WriteLine("\nVücut Kitle İndeksiniz: " + bmi.ToString("0.00"));
        Console.WriteLine("Durumunuz: " + durum);
    }
}
