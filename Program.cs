Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz.");
Console.WriteLine();

int soru=1;
string cevap;
if (soru ==1){
    Console.WriteLine("Türkiye'nin başkenti neresidir?");
    Console.WriteLine();
    Console.WriteLine("A) İzmir");
    Console.WriteLine("B) İstanbul");
    Console.WriteLine("C) Ankara");
    Console.WriteLine("D) Antalya");
    Console.WriteLine();
    Console.Write("Cevabınız: ");
    cevap=Console.ReadLine();

    if (cevap == "c" || cevap=="C"){
        soru = soru+1;
        
    }else{
        Console.Write("Üzgünüm yanlış cevap");
        return;
    }
}
if (soru==2){
    Console.WriteLine("Atatürk kaç yılında doğmuştur?");
    Console.WriteLine();
    Console.WriteLine("A)1925");
    Console.WriteLine("B)1912");
    Console.WriteLine("C)1818");
    Console.WriteLine("D)1881");
    Console.WriteLine();
    Console.Write("Cevabınız: ");
    cevap=Console.ReadLine();

    if(cevap=="d" || cevap=="D"){
        Console.Write("Tebrikler.");
        soru=soru+1;
    
    }else{
        Console.Write("Üzgünüm.");

    }
}