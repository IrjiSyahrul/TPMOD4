using System.Reflection.Metadata.Ecma335;

internal class Program
{
    class KodePos
    {
        public enum getKodePosEnum
        {
            Batununggal,Kujangsari,Mengger,Wates,Cijaura,Jatisari,Margasari,Sekejati,Kebonwaru,Maleer,Samoja
        }

        public static int getKodeposKelurahan(getKodePosEnum inputkode) {
            int[] Kodekelurahan = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 }


            return Kodekelurahan[(int)inputkode];
        }
    };

    private static void Main(string[] args)
    {
        
    }
}