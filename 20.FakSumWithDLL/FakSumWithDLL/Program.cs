using System.Numerics;
using BasaTop;
internal class Program
{
    private static void Main(string[] args)
    {
        basamak bas = new basamak();
    ilk:
        double val = 0;
        string gir = "";
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

        BigInteger num = bas.fak(x);
        Console.WriteLine(x + "!  = " + num + "\n");

        BigInteger Sonuc = bas.topla(num);

        Console.WriteLine("*************************************************");
        Console.WriteLine(x + "! Sayısının Basamakları Toplamı =" + Sonuc);
        Console.WriteLine("*************************************************");
        Console.WriteLine("Tekrar Denemek İçin Bir Tuşa Basınız");
        Console.ReadKey(true);
        Console.Clear();
        goto ilk;
    }
}