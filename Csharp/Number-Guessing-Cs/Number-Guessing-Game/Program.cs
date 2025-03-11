using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında bir sayı üretiyorum
        int tahmin = 0;
        int denemeSayisi = 0;

        Console.WriteLine("🎯 Sayı Tahmin Oyununa Hoş Geldiniz!");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");

        while (tahmin != rastgeleSayi)
        {
            Console.Write("Tahmininizi girin: ");
            string input = Console.ReadLine();

            // Kullanıcının girdiği değerin geçerli bir sayı olup olmadığını kontrol edeceğiz
            if (!int.TryParse(input, out tahmin))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                continue;
            }

            denemeSayisi++;

            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("📈 Daha büyük bir sayı girin!");
            }
            else if (tahmin > rastgeleSayi)
            {
                Console.WriteLine("📉 Daha küçük bir sayı girin!");
            }
            else
            {
                Console.WriteLine($"🎉 Tebrikler! {denemeSayisi} denemede doğru tahmin ettiniz: {rastgeleSayi}");
            }
        }
    }
}
