using System;

namespace andreaBonamo
{
    class Program
    {
        static void Main(string[] args)
        //il menù è scritto bene, l'utilizzo dello switch e del do-while nonostante non siano stati spiegati a lezione sono stati usati bene.
        // capacità di capire la traccia e risolverla. OK
        {
            int risp = 0;

            do
            {
                Console.WriteLine("menu,sceglio l'opzione di cui ha bisogno");
                Console.WriteLine("1=n multipli d k");
                Console.WriteLine("2=numeri interi divisori di n");
                Console.WriteLine("3=arrivederci");
                risp = int.Parse(Console.ReadLine());
                switch (risp)
                {
                    case 1:
                        {
                            Console.WriteLine("definisci k");
                            int k = int.Parse(Console.ReadLine());

                            Console.WriteLine("di quanti multipli hai bisogno?");
                            int n = int.Parse(Console.ReadLine());

                            multipli(k, n);

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("definisci n");
                            int n = int.Parse(Console.ReadLine());

                            bool primo = divisori(n);
                            Console.WriteLine("il numero è primo: " +primo);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("arrivederci");
                            break;
                        }

                }
            } while (risp != 3);
        }

        //esercizio quasi giusto
        //non stampa il numero di multipli inseriti dall'utente, probabilemnte hai sbagliato le condizioni del for
        //capacità di capire la traccia e risolverla: ABBASTANZA BUONA
        //l'esercizio nel complesso è scritto bene, devi solo fare più pratica sulle condizioni dei for e degli if
        //consiglio, questo esercizio con un while sarebbe stato un po' più semplice
        public static void multipli(int n,int k )
        {
            int s = 0;
            for (int i=0;i<=k;i++)
            {

                    s = n * i;
                
                if (s%2==0)
                {
                    Console.WriteLine("i numeri pari multipli di k sono " +s);
                }
            }
        }

        //esercizio scritto bene, sottolineo per iscritto che sei stato aiutato a completare la stampa del risultato per mancanza di tempo in classe, motivo mezzi
        //capacità di capire la traccia e di risolverla. OK
        public static Boolean divisori(int n)
        {
            int c = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    c++;
                }
            }
            if(c==2)
            {
                return true;
            }
            return false;
        }
    }
}
/**
*
*   ESERCIZIO 1)
*       2 pt / 2pt -> va bene!
*
*   ESERCIZIO 2)
*       2pt / 3pt -> hai sbagliato le condizioni del for e dell'if, non stampa il numero di multipli richiesti
*
*   ESERCIZIO 3)
*       3pt / 3pt -> esercizio svolto correttamente senza errori
*       1pt / 2pt -> nonostante l'esercizio sia giusto tolgo un punto per l'aiuto finale nella stampa del risultato
*
*   PUTEGGIO COMPLESSIVO
*       8pt / 10pt
*
*/