using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alessandroCastagna
{
    class Program
    {
        static void Main(string[] args)
        {
            int risp;

            //esercizio quasi totalmente giusto
            //i break vanno all'interno del case
            //capacità di apprendere la traccia e svolgerla. buona
           
            do
            {
                Console.WriteLine("Scegli l'opzione");
                Console.WriteLine("1 = Primi numeri multipli pari di k ");
                Console.WriteLine("2 = Numeri interi divisori di N");
                Console.WriteLine("3 = Fine");
                risp = int.Parse(Console.ReadLine());

                switch (risp)
                {
                    case 1:
                        {
                            int k, n;
                            Console.WriteLine("Inserisci k");
                            k = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci n");
                            n = int.Parse(Console.ReadLine());              

                            multipli(k,n);

                        }
                        break;
                    case 2:
                        {
                            int n;
                            Console.WriteLine("Inserisci un numero intero positivo");
                            n = int.Parse(Console.ReadLine());
                            int[] array = new int[n];
                            Console.WriteLine("i numeri interi divisori di n sono " + sunodd(n, array));
                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    default:
                        Console.WriteLine("errore il valore inserito non è valido, inserire valori da 1 a 3");
                        break;
                }
            } while (risp != 3);

            Console.ReadLine();
        }

        //esercizio nel complesso giusto per i numeri dispari
        //i numeri pari stampano il doppio dei multipli
        //capacità di capire la traccai e risolverla. parzialmente giusta
        public static void multipli(int k, int n)
        {
            int cont = 0;
            for (int i = 1; i<=n*2; i++)
            {
                int x = k * i;
                if (x%2==0)
                {
                    cont++;
                   

                    Console.WriteLine(x);
                }

            }
        }

        //esercizio parzialmente sbagliato
        //capacità di trovare i divisori, OK
        //capacità di capire la traccia e di risolverla. NO 
        //ritorna un numero intero (i-1) al posto di ritornare un valore booleano che stava a significare se il numero in input dosse primo o no. 
        //passaggio inutile di un array in input non richiesto e vuoto
        //esercizio quasi uguale ad un altro ragazzo. 
        //nome della funzione non pertinente
        public static int sunodd(int n, int[] array)
        {
            int i = 1;
            for ( i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                {

                    if (i != n / i)         //a cosa serve ? 
                    {
                        Console.WriteLine(i);
                    }
                       
                }
            }
            return i-1;         // i - 1 ?

        }
       
    }
}

/**
*
*   ESERCIZIO 1)
*       1.5pt / 2pt -> unico errore il break usato male
*
*   ESERCIZIO 2)
*       1.5pt / 3pt -> funziona per tutti i numeri dipari ma non per i pari
*
*   ESERCIZIO 3)
*       2.5pt / 3pt -> non capisco l'utilità di quell'if
*       0pt / 2pt -> esercizio non svolto
*
*   PUTEGGIO COMPLESSIVO
*       5pt / 10pt
*
*/