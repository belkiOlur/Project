using System.Numerics;
ilk:
double val = 0;
string gir = "";
BigInteger num = 1;
int sonuc = 0;
Console.WriteLine("İstenilen Sayının Faktöriyel Basamak Sayıları Toplamı ");
Console.Write("Faktöriyeli Alınacak Sayıyı Giriniz =");
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
        Console.Write("Boş Geçilemez Lütfen En Fazla 4 Basamaklı Bir Sayı Giriniz \n");
        goto ilk;
    }
    if (gir.Length > 4)
    {
        gir = gir.Substring(0, gir.Length - 1);
        Console.Write("\b \b");
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
int x = Convert.ToInt32(gir);
for (int i = 1; i <= x; i++)
{
    num *= i;
}
Console.WriteLine(x+"!  = "+num+"\n");
while (num > 0)
{
    sonuc += (int)(num % 10);
    num = num / 10;
}
Console.WriteLine("*************************************************");
Console.WriteLine(x + "! Sayısının Basamakları Toplamı =" + sonuc);
Console.WriteLine("*************************************************");
Console.WriteLine("Tekrar Denemek İçin Bir Tuşa Basınız");
Console.ReadKey(true);
Console.Clear();
goto ilk;