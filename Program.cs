class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;
        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
    }
}

