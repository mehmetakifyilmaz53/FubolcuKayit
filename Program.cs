namespace class_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            Console.WriteLine("isim Giriniz");
            futbolcu1.İsim = Console.ReadLine();
            //futbolcu1.İsim = "Mehmet Akif Yılmaz";
            Console.WriteLine("Pozisyon");
            futbolcu1.Pozisyon = Console.ReadLine();
            //futbolcu1.Pozisyon = "Çakılı Stoper";
            Console.WriteLine("Takımı giriniz");
            futbolcu1.Takımı = Console.ReadLine();
            //futbolcu1.Takımı = "Arsenal";
            Console.WriteLine("Yaş Giriniz");
            futbolcu1.Yaşı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sözleşme yılı giriniz");
            futbolcu1.SözleşmeYılı = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Futbolcu İsmi: " + futbolcu1.İsim);
            Console.WriteLine("Futbolcu Pozisyonu: " + futbolcu1.Pozisyon);
            Console.WriteLine("Futbolcu Takımı: " + futbolcu1.Takımı);
            Console.WriteLine("Futbolcu Yaşı: " + futbolcu1.Yaşı);
            Console.WriteLine("Futbolcu SözleşmeYılı: " + futbolcu1.SözleşmeYılı);



        }
    }
}