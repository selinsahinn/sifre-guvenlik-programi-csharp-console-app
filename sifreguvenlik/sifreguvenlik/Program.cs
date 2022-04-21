
using System;                           //sistemin claismasi icin gereken kutuphane

namespace SELINSAHIN_2B_NDP                 //isim uzayi
{
    class Program                       //program sinifi acilir
    {
        static void Main(string[] args)     //ana metoddur. ekrana cikti almak icin kullanilir.
        {
            bool dokuzKarakter;                 //kontrol islemi icin karakter sayisi tanimlanir           
            bool birBuyuk;                      //buyuk harf kontrolu icin anahtar tanimlama
            bool birKucuk;                      //kucuk harf kontrolu icin anahtar tanimlama
            bool birRakam;                      //rakam kontrolu icin anahtar tanimlama
            bool birSembol;                     //sembol kontrolu icin anahtar tanimlama
            bool birBosluk;                     //bosluk kontrolu icin anahtar tanimlanir

            dokuzKarakter = false;      //karakter sayisi yanlis olarak tanimlandi
            birBuyuk = false;      //buyuk harf yanlis olarak tanimlandi
            birKucuk = false;      //kucuk harf yanlis olarak tanimlandi
            birRakam = false;      //rakam yanlis olarak tanimlandi
            birSembol = false;      //sembol yanlis olarak tanimlandi
            birBosluk = false;      //bosluk yanlis olarak tanimlandi

            int genelSayac = 0;          //genel sayac 0'a esitlendi
            int karakterSayaci = 0;          //karakter sayaci 0'a esitlendi
            int buyukHarfSayaci = 0;          //buyuk harf sayisi 0'a esitlendi
            int buyukHarfPuani = 0;          //buyuk harf puani 0'a esitlendi
            int kucukHarfSayaci = 0;          //kucuk harf sayisi 0'a esitlendi
            int kucukHarfPuani = 0;          //kucuk harf puani 0'a esitlendi
            int rakamSayaci = 0;          //rakam sayisi 0'a esitlendi
            int rakamPuani = 0;          //rakam puani 0'a esitlendi
            int sembolSayaci = 0;          //sembol sayisi 0'a esitlendi
            int sembolPuani = 0;          //sembol puani 0'a esitlendi
            int boslukSayaci = 0;           //bosluk sayisi 0'a esitlendi

            while (true)                    //icerisi while ile surekli doner
            {
                Console.ForegroundColor = ConsoleColor.Cyan;    //rengi cyan yapar
                Console.Write("Şifre giriniz:");                  //konsola sifre girmelisiniz yazdirir
                Console.ForegroundColor = ConsoleColor.White;   //rengi beyaz yapar
                string girilenSifre = Console.ReadLine();       //kullanicidan string sifre okur
                char[] karakterler = girilenSifre.ToCharArray();    //sifreyi karakter karakter tanimlar

                if (karakterler.Length > 0)         //sifrenin bos olmadigi kontrol edilir
                {
                    karakterler = girilenSifre.ToCharArray();  //karakterler degiskeni sifrenin sayisina esitlenir
                    karakterSayisi();       //karakter sayisi fonksiyonu cagrilir
                    void karakterSayisi()       //karakter sayisi fonksiyonu olusturulur
                    {
                        if (karakterler.Length >= 9)       //karakter uzunlugu 9'a esit ve buyukse buraya girer
                        {
                            dokuzKarakter = true;       //dokuz karakter anahtari dogruya cevrilir
                            Console.ForegroundColor = ConsoleColor.Green;       //rengi yesile cevirir
                            Console.WriteLine(Environment.NewLine + "Parola en az 9 karakter içermektedir.");   //konsola uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;   //rengi beyaza cevirir
                            karakterSayaci = 10;            //karakter sayaci 10 olur
                        }
                        else                                        //(if saglanmazsa) karakter sayisi 9dan kucukse buraya girer
                        {
                            dokuzKarakter = false;                    //dokuz karakter anahtari yanlisa cevrilir
                            karakterSayaci = 0;                         //karakter sayaci 0 olur
                            Console.ForegroundColor = ConsoleColor.Red;          //rengi kirmiziya cevirir  
                            Console.WriteLine(Environment.NewLine + "Parola en az 9 karakterden oluşmalıdır.");         //konsola saglanmasi gereken kosul yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;        //rengi beyaza cevirir
                        }
                        buyukKontrol();                     //buyuk harf kontrol fonksiyonu cagrilir
                    }


                    void buyukKontrol()                     //buyuk harf kontrol fonksiyonu olusturulur
                    {
                        foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                        {
                            if (char.IsUpper(karakter))         //buyuk harf karakter sayisi kadar dongu doner
                            {
                                birBuyuk = true;                //buyuk harf anahtarini true yapar
                                buyukHarfSayaci += 1;           //buyuk harf sayacini 1 arttirir
                            }
                            if (buyukHarfSayaci == 1)              //buyuk harf sayisi 1 ise buraya girer
                            {
                                buyukHarfPuani = 10;            //buyuk harf puanini 10a esitler
                            }
                            else if (buyukHarfSayaci > 1)          //buyuk harf sayaci 1den buyukse buraya girer
                            {
                                buyukHarfPuani = 20;            //buyuk harf puani 20 olur
                            }
                            else                                //diger kosullar saglanmazsa buraya girer
                            {
                                buyukHarfPuani = 0;             //buyuk harf puanini 0 yapar
                            }
                        }
                        if (birBuyuk == true)                   //buyuk harf anahtari dogru ise buraya girer
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               //rengi yesil yapar
                            Console.WriteLine("Parolanız büyük harf içermektedir. Büyük harf sayısı: " + buyukHarfSayaci);      //konsola bilgi mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;               //rengi beyaza cevirir
                        }
                        else                                                //diger kosul saglanmazsa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                //rengi kirmizi yapar    
                            Console.WriteLine("Parolanız büyük harf içermelidir. Büyük harf sayısı: " + buyukHarfSayaci);    //konsola gerekli uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;               //rengi beyaza cevirir
                        }
                        kucukKontrol();                                         //kucuk harf kontrol fonksiyonu cagrilir
                    }

                    void kucukKontrol()                     //kucuk harf kontrol fonksiyonu olusturulur
                    {
                        foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                        {
                            if (char.IsLower(karakter))          //kucuk harf karakter sayisi kadar dongu doner    
                            {
                                birKucuk = true;               //kucuk harf anahtarini true yapar
                                kucukHarfSayaci += 1;           //kucuk harf sayacini 1 arttirir
                            }
                            if (kucukHarfSayaci == 1)              //kucuk harf sayisi 1 ise buraya girer
                            {
                                kucukHarfPuani = 10;           //kucuk harf puanini 10a esitler
                            }
                            else if (kucukHarfSayaci > 1)          //kucuk harf sayaci 1den buyukse buraya girer
                            {
                                kucukHarfPuani = 20;            //kucuk harf puani 20 olur
                            }
                            else                               //diger kosullar saglanmazsa buraya girer
                            {
                                kucukHarfPuani = 0;            //kucuk harf puanini 0 yapar
                            }
                        }
                        if (birKucuk == true)                  //kucuk harf anahtari dogru ise buraya girer
                        {
                            Console.ForegroundColor = ConsoleColor.Green;                  //rengi yesil yapar
                            Console.WriteLine("Parolanız küçük harf içermektedir. Küçük harf sayısı: " + kucukHarfSayaci);                  //konsola bilgi mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;               //rengi beyaza cevirir
                        }
                        else                                               //diger kosul saglanmazsa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;               //rengi kirmizi yapar
                            Console.WriteLine("Parolanız küçük harf içermelidir. Küçük harf sayısı: " + kucukHarfSayaci);   //konsola gerekli uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;               //rengi beyaza cevirir
                        }
                        rakamKontrol();                                        //rakam kontrol fonksiyonu cagrilir
                    }

                    void rakamKontrol()                     //rakam kontrol fonksiyonu olusturulur
                    {
                        foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                        {
                            if (char.IsNumber(karakter))          //rakam karakteri sayisi kadar dongu doner  
                            {
                                birRakam = true;             //rakam anahtarini true yapar
                                rakamSayaci += 1;          //rakam sayacini 1 arttirir
                            }
                            if (rakamSayaci == 1)              //rakam sayisi 1 ise buraya girer
                            {
                                rakamPuani = 10;           //rakam puanini 10a esitler
                            }
                            else if (rakamSayaci > 1)         //rakam sayaci 1den buyukse buraya girer
                            {
                                rakamPuani = 20;            //rakam puani 20 olur
                            }
                            else                               //diger kosullar saglanmazsa buraya girer
                            {
                                rakamPuani = 0;           //rakam puanini 0 yapar
                            }
                        }
                        if (birRakam == true)                 //rakam anahtari dogru ise buraya girer
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               //rengi yesil yapar
                            Console.WriteLine("Parolanız rakam içermektedir. Rakam sayısı: " + rakamSayaci);                 //konsola bilgi mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;                //rengi beyaza cevirir            
                        }
                        else                                              //diger kosul saglanmazsa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;              //rengi kirmizi yapar
                            Console.WriteLine("Parolanız rakam içermelidir. Rakam sayısı: " + rakamSayaci);     //konsola gerekli uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;                //rengi beyaza cevirir            
                        }
                        sembolKontrol();                                       //sembol kontrol fonksiyonu cagrilir
                    }


                    void sembolKontrol()                      //sembol kontrol fonksiyonu olusturulur       
                    {
                        foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                        {
                            if (char.IsSymbol(karakter))          //sembol karakter sayisi kadar dongu doner
                            {
                                birSembol = true;             //sembol anahtarini true yapar
                                sembolSayaci += 1;          //sembol harf sayacini 1 arttirir
                            }
                            if (sembolSayaci == 1)              //sembol sayisi 1 ise buraya girer
                            {
                                sembolPuani = 10;           //sembol harf puanini 10a esitler
                            }
                            else if (sembolSayaci > 1)        //sembol sayaci 1den buyukse buraya girer
                            {
                                sembolPuani += 10;           //sembol puanini 10 arttirir
                            }
                            else                               //diger kosullar saglanmazsa buraya girer
                            {
                                sembolPuani = 0;          //sembol puanini 0 yapar
                            }
                        }
                        if (birSembol == true)                 //sembol anahtari dogru ise buraya girer
                        {
                            Console.ForegroundColor = ConsoleColor.Green;                //rengi yesil yapar          
                            Console.WriteLine("Parolanız sembol içermektedir. Sembol sayısı: " + sembolSayaci);                //konsola bilgi mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;               //yazi rengini beyaza cevirir
                        }
                        else                                              //diger kosul saglanmazsa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;               //rengi kirmizi yapar         
                            Console.WriteLine("Parolanız sembol içermelidir. Sembol sayısı: " + sembolSayaci);    //konsola gerekli uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;              //rengi beyaz yapar      
                        }
                        boslukKontrol();                    //bosluk kontrol fonksiyonu saglanir
                    }

                    void boslukKontrol()                      //bosluk kontrol fonksiyonu olusturulur       
                    {
                        foreach (char karakter in karakterler)      //foreach dongusuyle diziler icindeki degerler kullanilir
                        {
                            if (char.IsWhiteSpace(karakter))          //bosluk karakter sayisi kadar dongu doner
                            {
                                birBosluk = true;             //bosluk anahtarini true yapar
                                boslukSayaci = 1;             //bosluk sayacini 1 yapar
                            }
                        }

                        if (boslukSayaci == 1)                 //bosluk anahtari dogru ise buraya girer
                        {
                            Console.ForegroundColor = ConsoleColor.Red;         //yazi rengini kirmizi yapar
                            Console.WriteLine("Parolanız boşluk içermemelidir.");    //konsola gerekli uyari mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;       //yazi rengini beyaza çevirir
                        }
                        else if (boslukSayaci == 0)                                             //diger kosul saglanmazsa
                        {
                            Console.ForegroundColor = ConsoleColor.Green;       //yazi rengini yesil yapar
                            Console.WriteLine("Parolanız boşluk içermemektedir.");    //konsola bilgi mesaji yazdirilir
                            Console.ForegroundColor = ConsoleColor.White;       //yazi rengini beyaza çevirir
                        }
                    }
                }

                genelSayac = karakterSayaci + buyukHarfPuani + kucukHarfPuani + rakamPuani + sembolPuani;
                //genel sayac puanini diger tum puanlarin toplamina esitler

                Console.ForegroundColor = ConsoleColor.DarkYellow;       //yazi rengini sari yapar
                Console.WriteLine(Environment.NewLine + "Genel Puan: " + genelSayac);     //konsola genel puan yazdirilir
                Console.ForegroundColor = ConsoleColor.White;       //yazi rengini beyaza çevirir

                karakterSayaci = 0;         //sayaci 0'a esitler
                buyukHarfSayaci = 0;        //sayaci 0'a esitler
                kucukHarfSayaci = 0;        //sayaci 0'a esitler
                rakamSayaci = 0;            //sayaci 0'a esitler
                sembolSayaci = 0;           //sayaci 0'a esitler
                boslukSayaci = 0;           //sayaci 0'a esitler

                if (dokuzKarakter == true && birBuyuk == true && birKucuk == true && birRakam == true && birSembol == true && boslukSayaci == 0)  //tum kosullar dogru saglaniyorsa donguye girer
                {
                    if (genelSayac >= 90)     //genel sayac 90a esit ve buyukse
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;       //yazi rengini koyu yesil yapar
                        Console.WriteLine("Tüm koşulları sağladınız." + Environment.NewLine);        //konsola yazi yazdirilir
                        Console.WriteLine("Şifreniz güçlüdür." + Environment.NewLine + Environment.NewLine);       //konsola sifreniz gucludur yazdirilir
                        Console.ForegroundColor = ConsoleColor.White;       //yazi rengini beyaza dondurur
                        return;
                    }
                    else if (genelSayac >= 70 && genelSayac < 90)    //genel puan 79-90 arasi ise
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;      //yazi rengini koyu yesil yapar
                        Console.WriteLine("Tüm koşulları sağladınız." + Environment.NewLine);         //konsola yazi yazdirilir
                        Console.WriteLine("Şifreniz uygundur." + Environment.NewLine + Environment.NewLine);     //konsola sifreniz uygundur yazdirilir
                        Console.ForegroundColor = ConsoleColor.White;      //yazi rengini beyaza dondurur
                        return;
                    }
                    else                                                    //diger kosullar saglanmaz ise buraya girer
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;     //yazi rengini koyu kirmizi yapar
                        Console.WriteLine(Environment.NewLine + "Şifrenizin puanı 70'ten küçük olduğu için kayıt olamazsınız." + Environment.NewLine + Environment.NewLine);     //konsola uyari mesaji yazdirilir
                        Console.ForegroundColor = ConsoleColor.White;      //yazi rengini beyaza dondurur
                    }
                }
                else                                                                 //kosullar saglanmazsa buraya girer
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;     //yazi rengini koyu kirmizi yapar
                    Console.WriteLine("Şifreniz uygun değildir." + Environment.NewLine + Environment.NewLine);     //konsola uyari yazisi yazdirilir
                    Console.ForegroundColor = ConsoleColor.White;     //yazi rengini beyaza dondurur
                }
            }
        }
    }
}