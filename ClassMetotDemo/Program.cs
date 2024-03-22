// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Adi = "Mehmet";
musteri1.Soyadi = "Acar";
musteri1.Yasi = 25;

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Adi = "Ali";
musteri2.Soyadi = "Yılmaz";
musteri2.Yasi = 30;

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Adi = "Ahmet";
musteri3.Soyadi = "Demir";
musteri3.Yasi = 35;

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
Console.WriteLine("-----------");
musteriManager.Add(musteri2);
Console.WriteLine("-----------");
musteriManager.Add(musteri3);
Console.WriteLine("-----------");

musteriManager.Delete(musteri3);
Console.WriteLine("-----------");

Console.WriteLine("Müşteri Listesi");
Musteri[] musteriler = new Musteri[] { musteri1, musteri2};
musteriManager.List(musteriler);
