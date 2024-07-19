// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i = 0;
while(i<10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int j = 1;
while (j<=20)
{
    Console.WriteLine(j);
    j++;
}
//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int k = 2;
while(k<=20)
{
    Console.WriteLine(k);
    k += 2;
   
}
//50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
int sayi = 50;
while(sayi<=150)
{
    toplam += sayi;
    sayi++;

}
Console.WriteLine("50 ile 150 sayıların arasındaki toplam " + toplam);
//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int ciftToplam = 0;
int tekToplam = 0;
int s = 1;
while (s<=120)

{
    if (s % 2 == 0)
        ciftToplam += i;
    else
        tekToplam += i;

    s++;
}
Console.WriteLine("1 ile 120 Arasındaki Çift Sayıların Toplamı " + ciftToplam);
Console.WriteLine("1 ile 120 Arasındaki Tek Sayıların Toplamı " + tekToplam);




