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
            public Transition(State stateAwal, State stateAkhir, Triger triger) {
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
        public State GetState(State stateAwal, State stateAkhir, Triger triger)
        {
             stateAkhir = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && triger == perubahan.triger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }
        public void TrigerAktif(Triger triger)
        {
            currentState = GetState(currentState, triger);
            Console.WriteLine("Pintu Terkunci");
            if (currentState == State.TERBUKA)
            {
                Console.WriteLine("Pintu tidak Terkunci");
            }
        }

        private State GetState(State currentState, Triger triger)
        {
            throw new NotImplementedException();
        }
    }

    private static void Main(string[] args)
    {
        DoorMachine objKunci = new DoorMachine();
        Console.WriteLine(objKunci.currentState);
        objKunci.TrigerAktif(Triger.KUNCI_PINTU);
        objKunci.TrigerAktif(Triger.BUKA_KUNCI);
    }
}