// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Basit Hesap Makinesi ===");

        //ilk sayıyı0
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        // ikinci sayıyı
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // işlem türü
        Console.WriteLine("İşlem seçin: (+, -, *, /)");
        char islem = Convert.ToChar(Console.ReadLine());

        double sonuc = 0;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçtiniz!");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}

