using ClassMetotDemo;

Musteri musteri1 = new Musteri();
{
    musteri1.Ad = "Kadir";
    musteri1.Soyad = "Cesur";
    musteri1.Yas = 24;

}
Musteri musteri2 = new Musteri();
{
    musteri2.Ad = "Ferhat";
    musteri2.Soyad = "Efe";
    musteri2.Yas = 23;
}
Musteri musteri3 = new Musteri();
{
    musteri3.Ad = "Mustafa";
    musteri3.Soyad = "Soykal";
    musteri3.Yas = 22;
}
MusteriManager Musteri= new MusteriManager();

Musteri.MusteriEkle(musteri1);
Musteri.MusteriEkle(musteri2);
Musteri.MusteriEkle(musteri3);
Musteri.MusteriSil(musteri3);
Musteri[] musteris = new Musteri[]
{
    musteri1,musteri2
};
Musteri.MusteriListele(musteris);



