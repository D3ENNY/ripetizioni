namespace piramide;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nesercizio 1)\nesercizio 2)\nesercizio 3)\nesercizio 4)\nesercizio 5)\nesercizio 6)");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        es1();
                        break;
                    }
                case 2:
                    {
                        es2();
                        break;
                    }
                case 3:
                    {
                        es3();
                        break;
                    }
                case 4:
                    {
                        es4();
                        break;
                    }
                case 5:
                    {
                        es5();
                        break;
                    }
                case 6:
                    {
                        es6();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("input non gestito");
                        break;
                    }
            }
        }
    }

    private static void es1()
    {
        Console.WriteLine("Dato in input un numero, stampare a video la sua tabellina\n");

        Console.WriteLine("inserire un numero (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("N -> " + n * i);
        }
    }

    private static void es2()
    {
        Console.WriteLine("Dato in input M e un incremento INC stampare a video la sequenza da M fino a 100 con incremento INC.\n");

        Console.WriteLine("inserire un numero (M) in input: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("inserire un numero (INC) in input: ");
        int inc = int.Parse(Console.ReadLine());

        while (m <= 100)
        {
            m += inc;
            Console.WriteLine("inc -> " + m);
        }
    }

    private static void es3()
    {
        Console.WriteLine("Scrivere un programma che, ricevuta in input una lingua dall’utente (italiano,inglese,francese,tedesco e spagnolo) lo saluti nella lingua scelta\n");

        Console.WriteLine("inserire una lingua");
        string language = Console.ReadLine();

        if (language == "italiano")
        {

        }
        else if (language == "inglese")
        {
            Console.WriteLine("ciao!");
        }
        else if (language == "francese")
        {
            Console.WriteLine("salut!");
        }
        else if (language == "tedesco")
        {
            Console.WriteLine("Tschuss!");
        }
        else if (language == "spagnolo")
        {
            Console.WriteLine("Hola!");
        }
        else
        {
            Console.WriteLine("lingua non gestita o non esistente");
        }
    }

    private static void es4()
    {
        Console.WriteLine("Dati in input due numeri interi n e k positivi stampare i primi n multipli di k\n");

        Console.WriteLine("inserire un numero (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("inserire un numero (K): ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= k + 1; i++)
        {
            Console.WriteLine("n -> " + n * i);
        }

    }

    private static void es5()
    {
        Console.WriteLine("Dati in input due numeri interi n e k positivi stampare i primi n multipli pari di k. Esempio: k=3 n=5 output stamperà i primi 5 multipli pari di 3 ossia 6, 12, 18, 24,30\n");

        int n, k, cnt = 0, cntK = 1;
        Console.WriteLine("inserire un numero (N)");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("inserire un numero (K)");
        k = int.Parse(Console.ReadLine());

        while (cnt < n)
        {
            int multiple = k * cntK;
            if (multiple % 2 == 0)
            {
                Console.WriteLine("number -> " + multiple);
                cnt++;
            }
            cntK++;
        }
    }

    private static void es6()
    {
        Console.WriteLine("Sia dato un numero intero positivo N inserito da tastiera. Si scriva un programma in C# che stampi i numeri interi che sono divisori (con resto uguale a zero) di N. Dire inoltre se N e’ un numero primo. Suggerimento.\n• Un numero M e’ divisore di un numero N se il resto della divisione N/M e’ uguale a zero.\n• Un numero e’ primo se e’ divisibile soltanto per 1 e per il numero stesso.\n");

        Console.WriteLine("inserire un numero (N)");
        int n = int.Parse(Console.ReadLine()), cnt = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("number -> " + i);
                cnt++;
            }
        }
        if(cnt==2)
            Console.WriteLine("il numero è primo");
    }

}
