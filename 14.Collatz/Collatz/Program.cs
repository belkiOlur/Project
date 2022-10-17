using System.Security.Cryptography.X509Certificates;
ilk:
long sonuc = 0;
int sayac = 0;
int i = 0;
int buyuk = 0;
int num = 0;
double val = 0;
double val1 = 0;
string gir = "";
string gir1 = "";
Console.WriteLine("En Büyük Collatz Bölen Adetini Bulmak İçin ");
Console.Write("Başlangıç Sayısı En Fazla 8 Basamaklı Sayı giriniz =");
ConsoleKeyInfo karakter;
do
{
    karakter = Console.ReadKey(true);
    if (karakter.Key != ConsoleKey.Backspace)
    {
        bool kontrol = double.TryParse(karakter.KeyChar.ToString(), out val);
        if (kontrol)
        {
            gir += karakter.KeyChar;
            Console.Write(karakter.KeyChar);
        }
    }
    else

    {
        if (karakter.Key == ConsoleKey.Backspace && gir.Length > 0)
        {
            gir = gir.Substring(0, gir.Length - 1);
            Console.Write("\b \b");
        }
    }
    if (karakter.Key == ConsoleKey.Enter && gir.Length <= 0)
    {
        Console.Write("\n");
        Console.Write("Boş Geçilemez Lütfen En Fazla 8 Basamaklı Bir Sayı Giriniz \n");
        goto ilk;
    }
    if (gir.Length > 8)
    {
        Console.Write("\nLütfen En Fazla 8 Basamaklı Bir Sayı Giriniz\n");
        Console.ReadKey(true);
        Console.Clear();
        goto ilk;
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
int x = Convert.ToInt32(gir);
enbas:
Console.Write("Bitiş Aralık Sayısı En Fazla 8 Basamaklı Sayı giriniz =");
ConsoleKeyInfo karakter1;
do
{
    karakter1 = Console.ReadKey(true);
    if (karakter1.Key != ConsoleKey.Backspace)
    {
        bool kontrol = double.TryParse(karakter1.KeyChar.ToString(), out val1);
        if (kontrol)
        {
            gir1 += karakter1.KeyChar;
            Console.Write(karakter1.KeyChar);
        }
    }
    else

    {
        if (karakter1.Key == ConsoleKey.Backspace && gir1.Length > 0)
        {
            gir1 = gir1.Substring(0, gir1.Length - 1);
            Console.Write("\b \b");
        }
    }
    if (karakter1.Key == ConsoleKey.Enter && gir1.Length <= 0)
    {
        Console.Write("\n");
        Console.Write("Boş Geçilemez Lütfen En Fazla 8 Basamaklı Bir Sayı Giriniz \n");
        goto enbas;
    }
    if (gir1.Length > 8)
    {
        Console.Write("\nLütfen En Fazla 8 Basamaklı Bir Sayı Giriniz\n");
        Console.ReadKey(true);
        Console.Clear();
        goto enbas;
    }
}
while (karakter1.Key != ConsoleKey.Enter);
Console.WriteLine("");
int y = Convert.ToInt32(gir1);

for (i = y-1; x< i && i< y; i--)
    {
    sayac = 0;
        if (i % 2 != 0)
        {
            long ni = ((3 * i) + 1);
            sayac++;
            while (ni != 1)
            {
                ni = ni / 2;
                sayac++;
                sonuc = ni;
                if (sonuc == 1)
                {
                sayac++;
                
                break;
            }
                if (ni % 2 != 0)
                {
                    ni = ((3 * ni) + 1);
                    sayac++;
                }
            }
        }
    if (i % 2 == 0)
    {
        long ni = i/2;
        sayac++;
        while (ni != 1)
        {
            if (ni % 2 == 0)
            {
                ni = ni / 2;
                sayac++;
            }
            sonuc = ni;
            if (sonuc == 1)
            {
                sayac++;
                break;
            }
            if (ni % 2 != 0)
            {
                ni = ((3 * ni) + 1);
                sayac++;
            }
        }
    }
    if(sayac>buyuk)
    {
        buyuk = sayac;
        num = i;       
    }
    
    
    }
Console.WriteLine("********************************************");
Console.WriteLine(num + " Sayısının Collatz Bölen Adedi =  " + buyuk);
Console.WriteLine("********************************************");
Console.WriteLine("Tekrar Denemek İçin Bir Tuşa Basınız");
Console.ReadKey(true);
goto ilk;

   
