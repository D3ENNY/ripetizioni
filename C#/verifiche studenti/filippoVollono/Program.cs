using System;

namespace filippoVollono
{
    class Program
    {
        static void Main(string[] args)
        {

            int risp;
            //menù funziona a parte il case 3 per chiudere
            do
            {
                Console.WriteLine("inserisci il numero");
                Console.WriteLine("1=stampa multipli di k");
                Console.WriteLine("2=stampa numeri");
                Console.WriteLine("3=fine");
                risp = int.Parse(Console.ReadLine());
                switch (risp)
                {
                    case 1:
                        {
                            //non richiama una funzione
                            //funziona solo con i numeri pari
                            int c = 0; int multipli = 0; int g = 0;
                            Console.WriteLine("inserisci il numero");
                            int k = int.Parse(Console.ReadLine());
                            Console.WriteLine("inserisci il  numero dei multipli ");
                            int n = int.Parse(Console.ReadLine());

                            for (int i = 0; i < n; i++)
                            {

                                multipli = k * i;
                                if (multipli % 2 == 0)
                                {
                                    Console.WriteLine("i multipli sono" + multipli);
                                }


                            }


                        }
                        break;

                    case 2:
                        {
                            int m = 0;
                            Console.WriteLine("inserisci il numero");
                            int n = int.Parse(Console.ReadLine());

                            numeri_primi(n);



                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                }

            } while (risp != 3);

        }
        
        //l'esercizio totalmente sbagliato
        //capacità di trovare i divisori assente 
        //capacità di capire la traccia e risolverla: no
        //l'esercizio non è pertinente alla traccia
        //manca il calcolo per sapere se il numero è primo oppure no
        
        static void numeri_primi(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    if (i / n == 0)
                    {
                        Console.WriteLine("i numeri pari sono" + i);
                    }
                }
            }
        }
        
/**
*
*   ESERCIZIO 1)
*       1 pt / 2pt -> consiglio utulizza un break per chiudere il menù, utilizza le funzioni per gli esercizi 
*
*   ESERCIZIO 2)
*       1.5pt / 3pt -> l'esercizio funziona parzialmente
*
*   ESERCIZIO 3)
*       0pt / 3pt -> non capisco l'utilità di quell'if
*       0pt / 2pt -> esercizio non svolto
*
*   PUNTEGGIO COMPLESSIVO
*       2.5pt / 10pt
*
*/
        
        
    }
}