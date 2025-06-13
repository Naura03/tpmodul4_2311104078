class Program
{
    static void Main(string[] args)
    {
        // === TABLE-DRIVEN: KodePos ===
        Console.WriteLine("=== Table-Driven: KodePos ===");
        KodePos kodePos = new KodePos();

        Console.WriteLine("Kode pos Batununggal: " + kodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode pos Cijaura: " + kodePos.getKodePos("Cijaura"));
        Console.WriteLine("Kode pos Sekejati: " + kodePos.getKodePos("Sekejati"));
        Console.WriteLine("Kode pos Unknown: " + kodePos.getKodePos("TidakAda"));

        Console.WriteLine();

        // === STATE-BASED CONSTRUCTION: DoorMachine ===
        Console.WriteLine("=== State-Based: DoorMachine ===");
        DoorMachine pintu = new DoorMachine();

        // Simulasi perubahan state
        pintu.Toggle(); // dari Terkunci -> Terbuka
        pintu.Toggle(); // dari Terbuka -> Terkunci
        pintu.Toggle(); // dari Terkunci -> Terbuka
    }
}
