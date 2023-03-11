﻿public class Program
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
        daerah inputDaerah = daerah.Margasari;
        int result = getKodePos(inputDaerah);
        Console.WriteLine(result);
    }
}