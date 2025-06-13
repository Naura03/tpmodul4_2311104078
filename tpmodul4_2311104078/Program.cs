class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos Batununggal: " + kodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode pos Cijaura: " + kodePos.getKodePos("Cijaura"));
    }
}
