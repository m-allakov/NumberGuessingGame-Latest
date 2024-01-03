namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main()
        {

            Random rnd1 = new Random();
            int sayac = 0;
            int sayi = rnd1.Next(1, 25);
            int sayi1 = rnd1.Next(1, 50);
            int sayi2 = rnd1.Next(1, 100);
            int level = 1;
            byte tHak = 0;
            bool kosul = false;




            
            Console.WriteLine("Oyunumuza hoş geldiniz\n");
            Console.WriteLine("Oyunu Kuralları:\n" +
                "1. Seçtiğiniz Seviyeye Göre Bir Sayı Tahmin Etmeniz İstenecek.\n" +
                "2. Seviye Yükseldikçe Tahmin Etmeniz Gereken Sayı Aralığı Büyüyecek ve Tahmin Hakkınız Azalacak. \n");

            Console.WriteLine("Lütfen Seviye Seçin \nKolay/Orta/Zor");
            string sLevel = Console.ReadLine().ToLower();


            if (sLevel == "kolay" && level <= 1)
            {
                for (int i = 12; i >= 0; i--)
                {


                    Console.WriteLine("Seviye: Kolay\n12 Tahmin Hakkınız Var\nSayı Aralığı1-25");
                    //Burada Bir Level Değişkeni Koydum Eğer biri doğru bilerse level 1 artacak bu level-i geçerse bir soru soracağim eğer cevap evet olursa bir sonraki levele geçecek

                    Console.Write("Tahmininizi Giriniz:");
                    int cvp = int.Parse(Console.ReadLine());

                    if (sayi == cvp)
                    {
                        level++;
                        Console.WriteLine("Tebrikler Doğru Tahmin!");
                        Console.WriteLine("Devam Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo1 = Console.ReadKey();
                        if (keyInfo1.Key == ConsoleKey.H)
                        {
                            break;
                        }
                        else if (keyInfo1.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            kosul = true;
                        }
                        break;
                    }
                    else if (sayi >= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{i}");
                        Console.Write($"Biraz Daha Büyük Sayı girin:");
                    }
                    else if (sayi <= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{i}");
                        Console.WriteLine($"Biraz Daha Küçük Sayı girin:");
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("Malesef Tahmin Hakkınız Bitmiştir :(\nŞansınızı Tekrar Denemek İstermisiniz?\nTekrar Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                        if (keyInfo2.Key == ConsoleKey.Enter)
                        {
                            Main();
                        }
                    }

                }

                
            }

            if (kosul || sLevel == "orta")
            {
                for (int j = 8; j >= 0; j--)
                {


                    Console.WriteLine("Seviye: Orta\n8 Tahmin Hakkınız Var\nSayı Aralığı 1-50");
                    //Burada Bir Level Değişkeni Koydum Eğer biri doğru bilerse level 1 artacak bu level-i geçerse bir soru soracağim eğer cevap evet olursa bir sonraki levele geçecek
                    level = 2;
                    Console.Write("Tahmininizi Giriniz:");
                    int cvp = int.Parse(Console.ReadLine());
                    Console.WriteLine(level);

                    if (sayi == cvp)
                    {
                        level++;
                        Console.WriteLine(level);
                        Console.WriteLine("Tebrikler Doğru Tahmin!");
                        Console.WriteLine("Devam Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.H)
                        {
                            break;
                        }
                        else if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();

                            kosul = true;
                        }
                        break;
                    }
                    else if (sayi >= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{j}");
                        Console.Write($"Biraz Daha Büyük Sayı girin:");
                    }
                    else if (sayi <= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{j}");
                        Console.WriteLine($"Biraz Daha Küçük Sayı girin:");
                    }
                    else if (j == 0)
                    {
                        Console.WriteLine("Malesef Tahmin Hakkınız Bitmiştir :(\nŞansınızı Tekrar Denemek İstermisiniz?\nTekrar Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                        if (keyInfo2.Key == ConsoleKey.Enter)
                        {
                            Main();
                        }
                    }
                    else
                    {
                        break;
                    }

                }

            }


            if (sLevel == "Zor" || kosul)
            {
                for (int i = 8; i >= 0; i--)
                {

                    Console.WriteLine("Seviye: Zor\n5 Tahmin Hakkınız Var\nSayı Aralığı 1-100");
                    //Burada Bir Level Değişkeni Koydum Eğer biri doğru bilerse level 1 artacak bu level-i geçerse bir soru soracağim eğer cevap evet olursa bir sonraki levele geçecek
                    level = 3;
                    Console.Write("Tahmininizi Giriniz:");
                    int cvp = int.Parse(Console.ReadLine());

                    if (sayi == cvp)
                    {
                        level++;
                        Console.WriteLine("Tebrikler Doğru Tahmin!");
                        Console.WriteLine("Devam Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        ConsoleKeyInfo keyInfo1 = Console.ReadKey();
                        if (keyInfo1.Key == ConsoleKey.H)
                        {
                            break;
                        }
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                        }
                    }
                    else if (sayi >= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{i}");
                        Console.Write($"Biraz Daha Büyük Sayı girin:");
                    }
                    else if (sayi <= cvp)
                    {
                        Console.WriteLine($"Kalan Tahmin Hakkınız:{i}");
                        Console.WriteLine($"Biraz Daha Küçük Sayı girin:");
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("Malesef Tahmin Hakkınız Bitmiştir :(\nŞansınızı Tekrar Denemek İstermisiniz?\nTekrar Etmak İçin 'Enter' \nOyundan Çıkmak İçin 'H' Tuşlarına Basınız");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                        if (keyInfo2.Key == ConsoleKey.Enter)
                        {
                            Main();
                        }
                    }

                }

            }











        }
    }
}