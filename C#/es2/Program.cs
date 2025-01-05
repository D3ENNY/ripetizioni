using System;

class Program
{
    static void Main()
    {
        int[] array = null;
        int[] pari = null;
        int[] dispari = null;

        while (true)
        {
            Console.WriteLine("\nScegli un'opzione:");
            Console.WriteLine("1 - Crea array di interi");
            Console.WriteLine("2 - Stampa array");
            Console.WriteLine("3 - Stampa media dei numeri");
            Console.WriteLine("4 - Stampa numeri pari multipli di 7");
            Console.WriteLine("5 - Dividi array in pari e dispari");
            Console.WriteLine("6 - Stampa unione degli array pari e dispari");
            Console.WriteLine("7 - Stampa intersezione di 2 array");
            Console.WriteLine("8 - Crea array alternato da due array");
            Console.WriteLine("9 - Esci");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    array = CreaArray();
                    break;
                case "2":
                    StampaArray(array);
                    break;
                case "3":
                    StampaMedia(array);
                    break;
                case "4":
                    StampaPariMultipliDiSette(array);
                    break;
                case "5":
                    (pari, dispari) = DividiPariDispari(array);
                    Console.WriteLine("Array pari:");
                    StampaArray(pari);
                    Console.WriteLine("Array dispari:");
                    StampaArray(dispari);
                    break;
                case "6":
                    var unione = UnioneArray(pari, dispari);
                    StampaArray(unione);
                    break;
                case "7":
                    Console.WriteLine("Inserisci il secondo array per l'intersezione:");
                    int[] array2 = CreaArray();
                    var intersezione = IntersezioneArray(array, array2);
                    StampaArray(intersezione);
                    break;
                case "8":
                    Console.WriteLine("Inserisci il secondo array di uguale lunghezza:");
                    int[] arrayA = CreaArray();
                    var alternato = ArrayAlternato(array, arrayA);
                    StampaArray(alternato);
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }

    static int[] CreaArray()
    {
        Console.WriteLine("Quanti numeri vuoi inserire?");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Inserisci il numero {i + 1}:");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void StampaArray(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("L'array è vuoto o non esiste.");
            return;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + (i == array.Length - 1 ? "\n" : ", "));
        }
    }

    static void StampaMedia(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("L'array è vuoto o non esiste.");
            return;
        }
        int somma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            somma += array[i];
        }
        double media = (double)somma / array.Length;
        Console.WriteLine($"La media dei numeri è: {media}");
    }

    static void StampaPariMultipliDiSette(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("L'array è vuoto o non esiste.");
            return;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0 && array[i] % 7 == 0)
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine();
    }

    static (int[] pari, int[] dispari) DividiPariDispari(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("L'array è vuoto o non esiste.");
            return (new int[0], new int[0]);
        }
        int[] pari = new int[array.Length];
        int[] dispari = new int[array.Length];
        int indexPari = 0, indexDispari = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                pari[indexPari++] = array[i];
            }
            else
            {
                dispari[indexDispari++] = array[i];
            }
        }

        Array.Resize(ref pari, indexPari);
        Array.Resize(ref dispari, indexDispari);

        return (pari, dispari);
    }

    static int[] UnioneArray(int[] array1, int[] array2)
    {
        int[] unione = new int[array1.Length + array2.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            unione[i] = array1[i];
        }
        for (int i = 0; i < array2.Length; i++)
        {
            unione[array1.Length + i] = array2[i];
        }
        return unione;
    }

    static int[] IntersezioneArray(int[] array1, int[] array2)
    {
        int[] intersezione = new int[Math.Min(array1.Length, array2.Length)];
        int index = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    intersezione[index++] = array1[i];
                    break;
                }
            }
        }

        Array.Resize(ref intersezione, index);
        return intersezione;
    }

    static int[] ArrayAlternato(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Gli array non hanno la stessa lunghezza.");
            return new int[0];
        }
        int[] risultato = new int[array1.Length + array2.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            risultato[i * 2] = array1[i];
            risultato[i * 2 + 1] = array2[array2.Length - 1 - i];
        }
        return risultato;
    }
}
