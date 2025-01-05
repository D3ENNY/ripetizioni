namespace es1;

class Program
{
    static void Main(string[] args)
    {
        int scelta;

            do
            {
                Console.WriteLine("Menu:");

                Console.WriteLine("1 - Area cerchio");
                Console.WriteLine("2 - Controllo numeri interi");
                Console.WriteLine("3 - Fermati quando superi 100");
                Console.WriteLine("4 - Quanti multipli di 10?");
                Console.WriteLine("5 - Stampa di una diagonale");

                Console.WriteLine("0 - Esci");

                Console.Write("Scegli un'opzione: ");

                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        // Area  del cerchio 

                        Console.Write("Inserisci il raggio: ");
                        double raggio = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Inserisci il valore di pgreco: ");   //chiedo il valore di P-greco all'utente perchè non so la formula
                        double pgreco = Convert.ToDouble(Console.ReadLine());

                        double area = pgreco * raggio * raggio;
                        Console.WriteLine("L'area del cerchio è: " + area);
                        return;

                    case 2:
                        // Controllo numeri interi

                        Console.Write("Inserisci un numero intero: ");

                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero < 0)
                        {
                            Console.WriteLine("Numero negativo");
                        }
                        else
                        {
                            Console.WriteLine("Numero positivo");
                        }
                        if (numero==0)
                        {
                        
                            Console.WriteLine("Hai inserito zero");
                        }
                        return;

                    case 3:
                        // Fermati quando superi 100
                        int num;
                        do
                        {
                            Console.Write("Inserisci un numero intero: ");

                            num = Convert.ToInt32(Console.ReadLine());

                        }   while (num <= 100);

                            return;

                    case 4:
                        // Quanti multipli di 10?
                        Console.Write("Quanti numeri vuoi inserire? ");
                        int nnumeri = Convert.ToInt32(Console.ReadLine());
                        int contatore = 0;
                        for (int i = 0; i < nnumeri; i++)
                        {
                            Console.Write("Inserisci un numero: ");
                            int numeroinserito = Convert.ToInt32(Console.ReadLine());
                            if (multiplo10(numeroinserito))
                            {
                                contatore++;
                            }
                        }
                        Console.WriteLine("Ci sono " + contatore + " multipli di 10");
                        return;

                    case 5:
                        // Stampa di una diagonale
                        Console.Write("Inserisci la dimensione della matrice: ");
                        int dimensione = Convert.ToInt32(Console.ReadLine());
                        diagonale(dimensione);
                        return;
                }

                Console.WriteLine();

            } while (scelta != 0);

               Console.WriteLine("Sei uscito dal programma");
        }

    static bool multiplo10(int numero) => numero % 10 == 0;

    static void diagonale(int n)     
    {
        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
                if (a + b == n - 1)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            Console.WriteLine();
        }
    }
}
