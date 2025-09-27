namespace es4;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new(); 
        int[] array = new int[10]; 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1,101);
        }

        stampaArray(array);

        array = InsertionSort(array);

        stampaArray(array);
    }

    static void stampaArray(int[] arr)
    {
        foreach (int i in arr)
            System.Console.Write(i + "; ");

        System.Console.WriteLine();
    }

    static int[] InsertionSort(int[] array)
    {
        int n = array.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            Console.WriteLine($"Passo {i}: Inseriamo {key}");

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;

            Console.WriteLine("Array attuale: " + string.Join(", ", array));
        }
        return array;
    }
}

