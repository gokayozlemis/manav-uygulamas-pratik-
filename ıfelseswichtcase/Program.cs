using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya Manavına Hoşgeldiniz!");
        Console.WriteLine("Mevcut Meyveler ve Fiyatları:");
        Console.WriteLine("Elma    : 2 TL");
        Console.WriteLine("Armut   : 3 TL");
        Console.WriteLine("Çilek   : 2 TL");
        Console.WriteLine("Muz     : 3 TL");
        Console.WriteLine("Diğer Meyveler: 4 TL");

        Console.WriteLine();
        Console.WriteLine("Lütfen satın almak istediğiniz meyveyi girin: (Elma, Armut, Çilek, Muz, Diğer)");

        string secim = Console.ReadLine().ToLower(); //Kullanıcı girdisini küçük harfe çeviriyoruz
        int fiyat = 0;

        switch (secim.ToLower())
        {
            case "elma":
                fiyat = 2;
                break;
            case "armut":
                fiyat = 3;
                break;
            case "çilek":
                fiyat = 2;
                break;
            case "muz":
                fiyat = 3;
                break;
            case "diğer meyveler":
                fiyat = 4;
                break;
            default:
                Console.WriteLine("Geçersiz meyve seçimi.");
                return;
        }
        Console.WriteLine($"Sectiğiniz {secim} fiyatı {fiyat} Tl'dir.");
    }
} // bence bu tür bir sorunu switch case ile çözümlemek daha kolay