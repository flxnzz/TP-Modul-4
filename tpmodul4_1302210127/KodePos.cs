using static DoorMachine;
public class KodePos
{
    public enum daerah
    {
        Batununggal, Kujangsari, Mengger, Wates, Cijaura,
        Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }
    public static int getKodePos(daerah input)
    {
        int[] postalCode = { 40266, 40287, 40267, 40256, 40287,
        40286, 40286, 40286, 40272, 40274, 40273};
        return postalCode[(int)input];
    }
    public static void Main(string[] args)
    {
        // Soal 1 Kode Pos
        daerah inputDaerah = daerah.Margasari;
        int result = getKodePos(inputDaerah);
        Console.WriteLine("Soal 1\nNama Daerah:\t" + inputDaerah +
            "\nKode Pos:\t" + result + "\n");

        // Soal 2 Pintu Buka/Tutup
        Pintu door = new Pintu();
        Console.WriteLine("Soal 2");
        door.activateTrigger(Trigger.KunciPintu);
    }
}