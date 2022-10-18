using System.Numerics;
ilk:
double val = 0;
string gir = "";
int i = 0;
int j = 0;
int k = 0;
int num1 = 0;
int num2 = 0;
int sum = 0;
Console.WriteLine("For Find Any Ambicable Number And Sum");
Console.Write("Please Give Me a Number =");
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
        Console.Write("Have to Give Me a Number \n");
        Console.Write("----------------------------\n");
        goto ilk;
    }
    if (gir.Length > 6)
    {
        gir = gir.Substring(0, gir.Length - 1);
        Console.Write("\b \b");
    }
}
while (karakter.Key != ConsoleKey.Enter);
Console.WriteLine("");
int x = Convert.ToInt32(gir);

for (i = x - 1; i < x; i--) 
{

    for (j = 1; j < i; j++) 
    {
        if (i % j == 0)
        {
            num1 += j;
        }        
    }
    for (k = 1; k < num1; k++)
    {
        if (num1 % k == 0)
        {
            num2 += k;
        }
    }
    if (num2 == i && num1 != num2)
    {
        sum += i;
        Console.WriteLine("Amicable Number is = "+i);
    }
    num1 = 0;
    num2 = 0;
}
Console.WriteLine("*************************************************");
Console.WriteLine("Ambicable Numbers Sum is = "+sum);
Console.WriteLine("*************************************************");
Console.ReadKey(true);
Console.Clear();
goto ilk;
