namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////
            ///////Temel C# Alıştırmalarım - Kampüs_365///////
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            #region Uygulama Dersi | 4 işlem && Katlar
            //Girilen sayıya kadar tüm sayıları topla, sonra 3 ve katlarına bölümünü ekrana yazdır.
            //Console.Write("Sayı gir: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 0; i <= sayi; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine($"Sayıların toplamı: {toplam}");

            //for (int i = 3; i <= toplam; i = i + 3)
            //{
            //    int sonuc = toplam / i;
            //    Console.WriteLine($"Sayıların toplamının {i}'ye bölümü: {sonuc}");
            //}
            #endregion
            #region Uygulama Dersi | Alan Hesapla

            //Console.Write("Karenin kenar uzunluğunu giriniz: ");
            //int kenar = Convert.ToInt32(Console.ReadLine());
            //int alan = kenar * kenar;
            //Console.WriteLine($"Karenin alanı {alan} cm'dir.");

            #endregion
            #region Uygulama Dersi | try-catch
            //try
            //{
            //    Console.WriteLine("Oda aydınlık mı? (E/H)");
            //    string cevap = Console.ReadLine();
            //    cevap.ToUpper();
            //    if (cevap == "E")
            //        Console.WriteLine("Işığı aç.");
            //    else if (cevap == "H")
            //        Console.WriteLine("Işığı kapat.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"İşlem sırasında hata alındı. Mesaj: {ex.Message}");
            //    Console.WriteLine($"Hata Detayı: {ex.StackTrace}");
            //} 
            #endregion
            #region Uygulama Dersi | try-catch2
            //try
            //{
            //    Console.WriteLine("Oda aydınlık mı? (E/H)");
            //    string cevap = Console.ReadLine();
            //    cevap.ToUpper();
            //    do
            //    {
            //        if (cevap == "E")
            //            Console.WriteLine("Işığı aç.");
            //        else if (cevap == "H")
            //            Console.WriteLine("Işığı kapat.");
            //    } while (cevap == "E" && cevap == "H");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"İşlem sırasında hata alındı. Mesaj: {ex.Message}");
            //    Console.WriteLine($"Hata Detayı: {ex.StackTrace}");
            #endregion
            #region Uygulama Dersi | Kullanıcı Girişi

            //string id;
            //int pw;
            //do
            //{
            //    Console.Write("Kullanıcı adınızı giriniz: ");
            //    id = Console.ReadLine();
            //    if (id == "bilgisayar")
            //    {
            //        Console.Write("Şifrenizi giriniz: ");
            //        pw = Convert.ToInt32(Console.ReadLine());
            //        if (pw == 1234)
            //        {
            //            Console.WriteLine("Giriş Başarılı! Hoşgeldin Ajan 47.");
            //        }
            //        else
            //            Console.WriteLine("1234'ü aklında tutamıyorsun, güle güle.");
            //    }

            //} while (id != "bilgisayar");

            #endregion
            #region Uygulama Dersi | *BOM Oyunu*

            //int bomNumber;
            //do
            //{
            //    Console.Write("Lütfen bir BOM sayısı giriniz: ");
            //    bomNumber = Convert.ToInt32(Console.ReadLine());

            //} while (bomNumber < 2 && bomNumber > 25);

            //int i = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        if (i % bomNumber == 0)
            //        {
            //            Console.WriteLine("Bilgisayar: BOM");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Bilgisayar: {i}");
            //        }
            //    }
            //    else
            //    {
            //        Console.Write("Sıra sende: ");
            //        string kullanici = Console.ReadLine();
            //        kullanici.ToUpper();

            //        if (i % bomNumber == 0)
            //        {
            //            if (kullanici != "BOM")
            //            {
            //                Console.WriteLine("Kaybettiniz.");
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            if (int.Parse(kullanici) != i)
            //            {
            //                Console.WriteLine("Kaybettiniz.");
            //                break;
            //            }
            //        }
            //    }
            //}

            //if (i > 100)
            //{
            //    Console.WriteLine("Oyun Berabere.");
            //}
            //Console.WriteLine("Oyun sona erdi.");

            #endregion
            #region Uygulama Dersi | Ortalama hesapla

            //Console.Write("1. Sınav notunuzu giriniz: ");
            //double s1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sınav notunuzu giriniz: ");
            //double s2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3. Sınav notunuzu giriniz: ");
            //double s3 = Convert.ToDouble(Console.ReadLine());

            //double ort = (s1 + s2 + s3) / 3;

            //if (ort >= 60)
            //{
            //    Console.WriteLine($"Tebrikler ortalamanız {ort} puan. Dersi geçtiniz." );
            //}
            //else
            //    Console.WriteLine($"Ortalamanız {ort} puan. Dersi geçemediniz.");

            #endregion
            #region Uygulama Dersi | HarfNotu

            //Console.Write("1. Vize notunuzu giriniz: ");
            //double v1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Vize notunuzu giriniz: ");
            //double v2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Final notunuzu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ort = ((v1 + v2) * 0.4) + (final * 0.6);

            //if (ort >= 80)
            //{
            //    Console.WriteLine($"Not ortalamanız {ort} puan. Harf notunuz AA. Dersi geçtiniz.");
            //}
            //else if (ort >= 60)
            //{
            //    Console.WriteLine($"Not ortalamanız {ort} puan. Harf notunuz BB. Dersi geçtiniz.");
            //}
            //else if (ort >= 45)
            //{
            //    Console.WriteLine($"Not ortalamanız {ort} puan. Harf notunuz DD. Dersi geçtiniz.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not ortalamanız {ort} puan. Harf notunuz FF. Dersi geçemediniz.");
            //}

            #endregion
            #region Uygulama Dersi | Trafik Lambası Switchcase

            //Console.Write("Trafik ışığının rengini giriniz: ");
            //string renk = Console.ReadLine();

            //switch (renk)
            //{
            //    case "kirmizi":
            //        Console.WriteLine("Lütfen Bekleyiniz...");
            //        break;
            //    case "sari":
            //        Console.WriteLine("Hazır olun.");
            //        break;
            //    case "yesil":
            //        Console.WriteLine("Geçebilirsiniz.");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı bilgi girdiniz...");
            //        break;
            //}

            #endregion
            #region Uygulama Dersi | Char Döngüsü

            //char i;
            //for (i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Uygulama Dersi | Kelimeyi ters çevirme

            //Console.Write("Bir kelime giriniz: ");
            //string word = Console.ReadLine();

            //Console.Write("Kelimenin ters hali : ");
            //for (int i = word.Length-1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}
            //Console.WriteLine("");
            #endregion
            #region Uygulama Dersi | Kelimeyi ters çevirme 2

            //Console.Write("Bir kelime giriniz: ");
            //string word2 = Console.ReadLine();

            //Console.Write("Kelimenin ters hali : ");

            //char[] harfler = word2.ToCharArray();
            //char[] yeniHarfler = harfler.Reverse().ToArray();
            //string tersWord2 = "";

            //foreach (var harf in yeniHarfler)
            //{
            //    tersWord2 += harf.ToString();
            //}

            //Console.WriteLine(tersWord2);
            #endregion
            #region Uygulama Dersi | Kelimeyi ters çevirme 3

            //Console.Write("Bir kelime giriniz: ");
            //string word3 = Console.ReadLine();

            //string newWord3 = "";
            //for (int i = word3.Length - 1; i >= 0; i--)
            //{
            //    newWord3 += word3.Substring(i, 1);
            //}
            //Console.WriteLine(newWord3);

            #endregion
            #region Tablo
            //Console.Write("╔");
            //Console.Write("═════════╗╔═════════");
            //Console.WriteLine("╗");
            //Console.WriteLine($"║         ║║         ║\n║         ║║         ║\n║   ╔═════╝╚═════╗   ║");
            //Console.WriteLine("╠═══╣Deniz Ceylan╠═══╣");
            //Console.WriteLine($"║   ╚═════╗╔═════╝   ║\n║         ║║         ║\n║         ║║         ║");
            //Console.Write("╚");
            //Console.Write("═════════╝╚═════════");
            //Console.Write("╝");
            #endregion
            #region Uygulama Dersi | SipNo Değişmeli Örnek

            //Console.Write("Lütfen isim soyisim bilginizi giriniz: ");
            //string isim = Console.ReadLine();
            //Console.Write("Lütfen sipariş numaranızı giriniz: ");
            //string sipNo = Console.ReadLine();
            //string tarih = Convert.ToString(DateTime.Now);

            //Console.WriteLine($"Sayın {isim}, {tarih} tarihinde almış olduğunuz ürünlere ait sipariş numaranız {sipNo}.\nBu numara ile siparişinizi takip edebilirsiniz.");
            #endregion
            #region Uygulama Dersi | SipNo Değişmeli Örnek 2
            //string message = "Sayın NNNNN, DDDDD tarihinde almış olduğunuz ürünlere ait sipariş numaranız OOOOO.\nBu numara ile siparişinizi takip edebilirsiniz.";

            //Console.Write("Lütfen isim soyisim bilginizi giriniz: ");
            //string name = Console.ReadLine();
            //Console.Write("Lütfen sipariş numaranızı giriniz: ");
            //string orderNo = Console.ReadLine();
            //string date = Convert.ToString(DateTime.Today.ToString("dd.MM.yyyy"));

            //message = message.Replace("NNNNN", name);
            //message = message.Replace("OOOOO", orderNo);
            //message = message.Replace("DDDDD", date);

            //Console.WriteLine(message);

            #endregion
            #region Uygulama Dersi | Input Dizi oluştur - En uzun elemanı, index no ve karakter sayısını ekrana yazma

            //string[] dizi = new string[5];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. elemanı giriniz:");
            //    dizi[i] = Console.ReadLine();
            //}
            //int indexNo = 0;
            //int karakterSayisi = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i].Length > karakterSayisi)
            //    {
            //        karakterSayisi = dizi[i].Length;
            //        indexNo = i;
            //    }
            //}

            //Console.WriteLine($"En uzun eleman: {dizi[indexNo]}\nIndex Numarası: {indexNo}\nKarakter Sayısı: {karakterSayisi}");

            #endregion

        }

    }
}