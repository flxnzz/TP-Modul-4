using System;
using System.Security.Cryptography.X509Certificates;

public class DoorMachine
{
    public enum doorState { Terkunci, Terbuka };
    public enum Trigger { KunciPintu, BukaPintu };
    public class Pintu
    {
        public doorState currentState = doorState.Terkunci;
        public class Transition
        {
            public doorState stateAwal;
            public doorState stateAkhir;
            public Trigger trigger;
            public Transition(doorState stateAwal, doorState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi = { new Transition(doorState.Terkunci, doorState.Terkunci, Trigger.KunciPintu),
            new Transition(doorState.Terkunci, doorState.Terbuka, Trigger.BukaPintu),
            new Transition(doorState.Terbuka, doorState.Terbuka, Trigger.BukaPintu),
            new Transition(doorState.Terbuka, doorState.Terkunci, Trigger.KunciPintu)
        };

        public doorState nextState(doorState stateAwal, Trigger trigger)
        {
            doorState finalState = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition temp = transisi[i];
                if (stateAwal == temp.stateAwal && trigger == temp.trigger)
                {
                    finalState = temp.stateAkhir;
                }
            }
            return finalState;
        }
        public void activateTrigger(Trigger trigger)
        {
            currentState = nextState(currentState, trigger);
            if (currentState == doorState.Terkunci)
            {
                Console.WriteLine("Pintu Terkunci");
            }
            else if (currentState == doorState.Terbuka)
            {
                Console.WriteLine("Pintu Terbuka");
            }
        }
    }
}
