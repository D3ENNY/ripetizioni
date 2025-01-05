using System;

namespace gabrieleDossena
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("1=primo es");
                Console.WriteLine("2=secondo es");
                Console.WriteLine("3=fine menù");
                int risposta = 0;
                risposta = int.Parse(Console.ReadLine());

                if(risposta==1)
                {
                    int k; int n;
                    Console.WriteLine("inserisci i valori di n e k");
                    n = int.Parse(Console.ReadLine());
                    k = int.Parse(Console.ReadLine());
                    primo_es(n, k);
                    Console.WriteLine("\n");
                }

                else if(risposta==2)
                {
                    Console.WriteLine("inserisci un numero");
                    int n = int.Parse(Console.ReadLine());
                    secondo_es(n);
                    Console.WriteLine("\n");
                }
                else if(risposta==3)
                {
                    break;
                }
               


            } 
        }

        // esercizio totalmente sbagliato
        // l'esercizo di logica è sbagliato e rimane bloccato in un loop infinito
        //capacità di capire la traccia. MINIMA
        static void primo_es(int n,int k)
        {
            int tab=0;
            int cnt2=1;
            int cnt=0;
            while(cnt<k)
            {
                if(n%cnt2==1)
                {
                    tab= k * cnt;
                    cnt++;
                   
                }

            }
            Console.WriteLine(tab);            
        }
        //esercizio parzialmente sbagliato
        //capacità di trovare i divisori, OK
        //capacità di capire la traccia e di risolverla. circa 
        //mancanza di metà esercizio
        //esercizio quasi uguale ad un altro ragazzo. 
        static void secondo_es(int n)
        {
          

            for (int factor = 1; factor <= n; ++factor) 
            {
                if (n % factor == 0)
                {
                    if (factor != n / factor) //non serve
                    
                        Console.WriteLine(factor);
                }
            }
        }
    }
}

/**
*
*   ESERCIZIO 1)
*       2 pt / 2pt -> consiglio di usare unp switch al posto degli if
*
*   ESERCIZIO 2)
*       0pt / 3pt -> l'esercizio non funziona, e rimane bloccato nel while senza uscire
*
*   ESERCIZIO 3)
*       2.7pt / 3pt -> non capisco l'utilità di quell'if
*       0pt / 2pt -> esercizio non svolto
*
*   PUNTEGGIO COMPLESSIVO
*       4.7pt / 10pt
*
*/