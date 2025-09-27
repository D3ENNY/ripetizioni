import java.util.Scanner;

public class Main {

    private static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) {

        System.out.println("Quanti posti conterrà il garage? ");
        int numeroPosti = sc.nextInt();

        Garage garage = new Garage(numeroPosti);

        int scelta;
        do{
            String targa, marca, modello;
            int nPosto;

            System.out.println("""
                        ---Menù---
                        1. Inserisci auto
                        2. Rimuovi auto
                        3. Verifica Posto
                        4. Stato garage
                        
                        0. Esci
                        ----------
                        inserisci numero: 
                    """);
            scelta = sc.nextInt();
            sc.nextLine(); //svuota buffer

            switch(scelta){
                case 1:
                    System.out.println("Inserisci targa auto: ");
                    targa = sc.nextLine();
                    System.out.println("Inserisci marca: ");
                    marca = sc.nextLine();
                    System.out.println("Inserisci modello: ");
                    modello = sc.nextLine();
                    garage.inserisciAuto(targa, marca, modello);
                    break;

                case 2:
                    System.out.println("Inserisci targa: ");
                    targa = sc.nextLine();
                    garage.rimuoviAuto(targa);
                    break;

                case 3:
                    System.out.println("inserisci numero posto: ");
                    nPosto = sc.nextInt();
                    sc.nextLine(); //svuoto il buffer
                    garage.verificaPosto(nPosto);
                    break;

                case 4:
                    garage.statoGarage();
                    break;

                default:
                    System.out.println("Input non gestito");
            }

        }while(scelta != 0);

        sc.close();
    }
}