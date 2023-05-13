namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Firstname = "Oğuz";
            musteri1.Lastname = "Kaan";
            musteri1.PhoneNumber = 55500011;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Firstname = "Dede";
            musteri2.Lastname = "Korkut";
            musteri2.PhoneNumber = 55511100;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 2;
            musteri3.Firstname = "Yusuf";
            musteri3.Lastname = "Eraslan";
            musteri3.PhoneNumber = 55522200;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.WriteLine("-----------------------------------------------");

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,}; 
            musteriManager.MusteriListesi(musteriler);
            
        }
    }
}