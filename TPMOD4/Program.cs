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

    public enum Triger {BUKA_KUNCI,KUNCI_PINTU };
    public enum State { TERKUNCI,TERBUKA };
    class DoorMachine {
        public State currentState = State.TERKUNCI;

        public class Transition
        {
            public State stateAwal;
            public State stateAkhir;
            public Triger triger;
            public Transition (State stateAwal, State stateAkhir, Triger triger) {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.triger = triger;   
            }

        }
        Transition[] transisi =
        {
            new Transition(State.TERKUNCI,State.TERBUKA, Triger.BUKA_KUNCI),
            new Transition(State.TERKUNCI, State.TERKUNCI, Triger.KUNCI_PINTU),

        };
        public State nexState(State stateAwal, State stateAkhir, Triger triger)
        {

        };

    }

    private static void Main(string[] args)
    {
        
    }
}