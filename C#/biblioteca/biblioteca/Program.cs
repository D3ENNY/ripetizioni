namespace biblioteca
{
    internal class Program
    {
        static Biblio[] biblioteche = new Biblio[5];
        static void Main(string[] args)
        {
            int scelta = 0;
            do
             {
                Console.WriteLine("""
                    1) Aggiungi Biblioteca
                    2) Modifica Biblioteca
                    3) Rimuovi Biblioteca
                    4) Prestito Biblioteca
                    5) Esci
                    """);

                switch (scelta)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3: 
                        break;
                    case 4:
                        break;
                    case 5: 
                        break;
                    default:
                        Console.WriteLine("Input non gestito");
                        break;
                }
            }
            while (scelta != 5);
        }

        static void AggiungiBiblioteca()
        {

        }
    }
}