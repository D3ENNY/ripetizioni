namespace es3;

class Program
{
    static void Main(string[] args)
    {
        int[] numeri = {4,14,7,0,9,21,3,12};
        List<int> pari = null;
        List<int> dispari = null;
        
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Crea array di interi");
            Console.WriteLine("2 - Stampa array");
            Console.WriteLine("3 - Stampa media dei numeri");
            Console.WriteLine("4 - Stampa numeri pari multipli di 7");
            Console.WriteLine("5 - Separare numeri pari e dispari");
            Console.WriteLine("6 - Stampa unione di due array");
            Console.WriteLine("7 - Stampa intersezione di due array");
            Console.WriteLine("8 - Combinare due array con ordine inverso");
            Console.WriteLine("9 - Combina due array di uguale lunghezza");
            Console.WriteLine("10 - Combina due array di lunghezza diversa");
            Console.WriteLine("0 - Esci");
            Console.Write("Scegli un'opzione: ");
            int scelta = Convert.ToInt32(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    Console.Write("Quanti numeri vuoi inserire nell'array? ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    numeri = new int[n];
                    Console.WriteLine("Inserisci i numeri dell'array:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ": ");
                        numeri[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    break;

                case 2:
                    // richiamo la funzione stampa array per stampare l'array generato in precedenza
                    StampaArray(numeri);

                    break;

                case 3:
                    int somma = 0;
                    //calcolo la somma di tutti i numeri di un array
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        somma += numeri[i];
                    }
                    //ne stampo la media usando la formula somma / numero di elementi
                    Console.WriteLine((float)somma / numeri.Length);

                    break;

                case 4:
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        //un numero è pari se il resto della sua divisione per 2 è uguale a 0
                        //un numero è multiplo di un altro, se è possibile dividerlo per l'altro senza avere resto
                        if(numeri[i] % 2 == 0 && numeri[i] % 7 == 0)
                        {
                            Console.WriteLine(numeri[i]);
                        }
                    }

                    break;

                case 5:
                    //per questo esercizio utilizzo una collection diversa, una lista, per facilitarne l'aggiunta, non sapendo a che posizione sia presente l'ultimo valore nell'array
                    //ometto List<int> dopo new, perchè dotnet permette di riconoscere da solo il tipo a cui fare la new

                    pari = new();                     //List<int> pari = new();
                    dispari = new();                  //List<int> dispari = new();

                    for (int i = 0; i < numeri.Length; i++)
                    {
                        if(numeri[i] % 2 == 0)
                        {
                            pari.Add(numeri[i]);
                        }
                        else
                        {
                            dispari.Add(numeri[i]);
                        }
                    }
                    //sfrutto ToArray() per convertire la lista in array e usare quindi la funzione stampaArray
                    StampaArray(pari.ToArray());
                    StampaArray(dispari.ToArray());
                    break;

                case 6:
                    int[] unione = UnioneArray(pari.ToArray(), dispari.ToArray());
                    StampaArray(unione);
                    break;

                case 7:
                    int[] intersezione = IntersezioneArray(pari.ToArray(), dispari.ToArray());
                    StampaArray(intersezione);
                    break;

                case 8:
                    int[] alternato = ArrayAlternato(pari.ToArray(), dispari.ToArray());
                    StampaArray(alternato);
                    break;

                case 9:
                    int[] ris = ArrayUgualePosizione(pari.ToArray(), dispari.ToArray());
                    StampaArray(ris);
                    break;

                case 10:

                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
            Console.WriteLine();
            }
        }

    // Funzione per stampare un array
    static void StampaArray(int[] array)
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] UnioneArray(int[] arr1, int[] arr2)
    {
        int[] arrUnione = new int[arr1.Length + arr2.Length];
        int cnt = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            //utilizzo cnt come variabile di appoggio nel modo che non perda il valore a fine ciclo, per tenere conto della posizione dell'array unione
            arrUnione[cnt] = arr1[i];
            cnt++;
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            arrUnione[cnt] = arr2[i];
            cnt++;
        }
        
        return arrUnione;
    }

    static int[] IntersezioneArray(int[] arr1, int[] arr2)
    {
        List<int> intersezione = new();

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                //controllo quali elementi del primo array siano uguali agli elementi del secondo
                if(arr1[i] == arr2[j])
                {
                    intersezione.Add(arr1[i]);
                }
            }
        }

        return intersezione.ToArray();
    }

    static int[] ArrayAlternato(int[] arr1, int[] arr2)
    {
        int[] risultato = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            //i*2 mi permette di saltare una posizione ogni volta -> i=0, pos=0 || i=1, pos=2
            risultato[i * 2] = arr1[i];
            //i*2+1 fa la stessa cosa di quello di prima ma prende le posizioni che salta la riga sopra
            //arr2.Lenght-1-i va a prendere i valori dalla fine dell'array 2 tornando indietro di i posizioni
            risultato[i * 2 + 1] = arr2[arr2.Length - 1 - i];
        }
        return risultato;
    }

    static int[] ArrayUgualePosizione(int[] arr1, int[] arr2)
    {
        int[] risultato = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            risultato[i*2] = arr1[i];
            risultato[i*2+1] = arr2[i];
        }

        return risultato;
    }
}
