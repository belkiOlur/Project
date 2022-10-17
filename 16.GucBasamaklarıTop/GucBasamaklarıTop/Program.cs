using System.Numerics;

ilk:
int sonuc = 0;
double val = 0;
double val1 = 0;
string gir = "";
string gir1 = "";
Console.WriteLine("X Üzeri Y'nin Basamak Sayıları Toplamı ");
Console.Write("X için değer Giriniz =");
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
        Console.Write("Boş Geçilemez Lütfen En Fazla 2 Basamaklı Bir Sayı Giriniz \n");
        goto ilk;
    }
    if (gir.Length > 2)
    {
        gir = gir.Substring(0, gir.Length - 1);
        Console.Write("\b \b");
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
int x = Convert.ToInt32(gir);

enbas:
Console.Write("Y İçin Değer Giriniz =");
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
        Console.Write("Boş Geçilemez Lütfen En Fazla 4 Basamaklı Bir Sayı Giriniz \n");
        goto enbas;
    }
    if (gir1.Length > 4)
    {
        gir1 = gir1.Substring(0, gir1.Length - 1);
        Console.Write("\b \b");
    }
}
while (karakter1.Key != ConsoleKey.Enter);
Console.WriteLine("");
int y = Convert.ToInt32(gir1);

BigInteger pd = BigInteger.Pow(x, y);
Console.WriteLine("Sayı Değeri ="+pd+"\n");
while (pd > 0)
{
    sonuc += (int)(pd % 10);
    pd = pd / 10;
}
Console.WriteLine("*************************************************");
Console.WriteLine(x+" Üzeri "+y+" Sayısının Basamakları Toplamı ="+sonuc);
Console.WriteLine("*************************************************");
Console.WriteLine("Tekrar Denemek İçin Bir Tuşa Basınız");
Console.ReadKey(true);
Console.Clear();
goto ilk;