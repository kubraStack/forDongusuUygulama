using System;

namespace dongulerForUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uygulama 1

           // 1- Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki tüm sayıları ekrana yazdırınız.
                //    Console.Write("Başlangıç sayısı: ");
                //    int baslangic = int.Parse(Console.ReadLine());

                //    System.Console.Write("Bitiş sayısı: ");
                //    int bitis = int.Parse(Console.ReadLine());

                //    System.Console.Write("Artış miktarı: ");
                //    int artısMiktari = int.Parse(Console.ReadLine());
                //    int sayac = 0;
                //    int toplam = 0;
                //    for(int i = baslangic; i <= bitis; i=i+artısMiktari){
                //     sayac++;
                //     toplam+=i;
                //     System.Console.WriteLine($"{sayac}. sayı: {i} ");
                //    }
                //    System.Console.WriteLine("Toplam" + toplam);

            int[] sayilar = {1,3,5,6,7,23,67,90};

           // 2- sayilar dizisindeki hangi sayılar 3'ün katıdır?
                // for(int i = 0; i < sayilar.Length; i++){
                //     if(sayilar[i]%3==0){
                //         System.Console.WriteLine(sayilar[i]);
                //     }
                // }
         
           // 3- sayilar dizisindeki sayıların toplamı ve çarpımı kaçtır?
                //    int toplam =0;
                
                //    for(int i = 0; i < sayilar.Length; i++){
                //         toplam+=sayilar[i];
                //     }
                //    System.Console.WriteLine(toplam);

                // int toplam = 0;
                // long carpim = 1;
                // for(int i = 0; i < sayilar.Length; i++){
                //     toplam += sayilar[i];
                //     carpim *= sayilar[i];
                // }
                // System.Console.WriteLine("toplam: " + toplam);
                // System.Console.WriteLine("çarpım: " + carpim);
           // 4- sayilar dizisindeki tek  sayıların karesini ekrana yazdırınız.
                
                // for(int i = 0; i < sayilar.Length; i++){
                //     if(sayilar[i]%2 == 1){
                //         System.Console.WriteLine(sayilar[i]*sayilar[i]);
                //     }
                // }

           string[] arabalar = {"Opel", "Mazda", "Toyota", "Bmw", "Mercedes"};
           // 5- araba dizisindeki en az 5 karakterli araç isimlerini yazdırın.

            for(int i = 0; i < arabalar.Length; i++){
                if(arabalar[i].Length >= 5){
                    System.Console.WriteLine(arabalar[i]);
                }
            }
        }
    }
}
