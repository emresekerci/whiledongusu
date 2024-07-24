int i = 1;
while (i <= 10)

{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine("------------------------------------------------------------------");
int a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;
}
Console.WriteLine("------------------------------------------------------------------");
int b = 2;
while (b <= 20)
{
    Console.WriteLine(b);
    b += 2;
}
Console.WriteLine("------------------------------------------------------------------");

int sayiToplam = 0;
int c = 50;
while (c <= 150)
{
    c++;
    sayiToplam += c;
}
Console.WriteLine("50-150 arasındaki sayıların toplamı ----> " + sayiToplam);

Console.WriteLine("------------------------------------------------------------------");

int tekSayiToplam = 0;
int ciftSayiToplam = 0;
int d = 1;
while (d <= 120)
{
    if (d % 2 == 0)
    {
        ciftSayiToplam += d;
    }
    else
    {
        tekSayiToplam += d;
    }

    d++;


}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftSayiToplam);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekSayiToplam);