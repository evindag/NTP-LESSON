using Class_sinav_sorusu;

Console.WriteLine("Üçgenin tabanını giriniz:");
double taban = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Üçgenin yüksekliğini giriniz:");
double yukseklik = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Üçgenin 1. kenarını giriniz:");
double kenar1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Üçgenin 2. kenarını giriniz:");
double kenar2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Üçgenin 3. kenarını giriniz:");
double kenar3 = Convert.ToDouble(Console.ReadLine());

Ucgen ucgen = new Ucgen(taban, yukseklik, kenar1, kenar2, kenar3);
Console.WriteLine("Çevre: " + ucgen.CevreHesapla());
Console.WriteLine("Alan: " + ucgen.AlanHesapla());
Console.ReadLine();