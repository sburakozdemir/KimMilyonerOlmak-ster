int DogruCevap = 0;
string cevap;

Console.WriteLine("Kim Milyoner Olmak İster ? Yarışmasına Hoşgeldiniz ");
Console.WriteLine("3 sorudan 2 tanesini doğru cevaplamanız halinde milyoner olacaksınız ");

// 1. Soru
Console.WriteLine("1 -> Hangisi Güneş Sistemi'nde en büyük gezegendir?");
Console.WriteLine("a) Jüpiter");
Console.WriteLine("b) Satürn");
cevap = Console.ReadLine().ToLower();

if (cevap == "a")
{
    DogruCevap++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap.");
}

// 2. Soru
Console.WriteLine("2 -> Leonardo da Vinci'nin ünlü tablosu Mona Lisa hangi müzede sergilenmektedir?");
Console.WriteLine("a) Louvre Müzesi");
Console.WriteLine("b) British Müzesi");
cevap = Console.ReadLine().ToLower();

if (cevap == "a")
{
    DogruCevap++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap.");
}

// Eğer ilk iki sorudan sonra 2 doğru cevap veremediyse, 3. soruya geçeriz.
if (DogruCevap < 2)
{
    // 3. Soru
    Console.WriteLine("3 -> 1969 yılında Ay'a ilk ayak basan astronot kimdir?");
    Console.WriteLine("a) Neil Armstrong");
    Console.WriteLine("b) Buzz Aldrin");
    cevap = Console.ReadLine().ToLower();

    if (cevap == "a")
    {
        DogruCevap++;
        Console.WriteLine("Doğru cevap!");
    }
    else
    {
        Console.WriteLine("Yanlış cevap.");
    }
}

// Final sonucu
if (DogruCevap >= 2)
{
    Console.WriteLine("Tebrikler, 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Maalesef, büyük ödülü kazanamadınız.");
}