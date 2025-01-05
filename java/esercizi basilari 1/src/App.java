import java.io.BufferedReader;
import java.io.InputStreamReader;

public class App {
    public static void main(String[] args) throws Exception{

        BufferedReader tastiera = new BufferedReader(new InputStreamReader(System.in));
        int n;

        //serve per prendere in input un numero perforza positivo
        do {
            n = Integer.valueOf(tastiera.readLine());
        } while (n < 0);

        //prende tutti i numeri da 0 al numero preso in input
        for(int i=0; i<n; i++){
            //controlla se il numero i è dispari
            if(i % 2 != 0){
                System.out.println(i);
            }
        }
    }

    public static void es1() throws Exception{
        
        //stampa i primi numeri N dispari successivi al numero preso in input A

        /**
         * 
         * input di A, N
         * dispari
         * stampare dei numeri
         * 
         */
        BufferedReader tastiera = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("inserisci numero N");
        int n = Integer.valueOf(tastiera.readLine());     //n numero
        System.out.println("inserisci numero A");
        int a = Integer.valueOf(tastiera.readLine());     // numero iniziale
        System.out.println("==========");

        int cnt = 0;    //serve a contare quanti numeri dispari abbiamo trovato
        do{
            a++;
            if(a % 2 != 0){
                System.out.println(a);
                cnt++;
            }
        }while(cnt < n);

    }

    public static void es1_1() throws Exception{

        //stampa i primi numeri N dispari successivi al numero preso in input A

        /**
         * 
         * input di A, N
         * dispari
         * stampare dei numeri
         * 
         */

        BufferedReader tastiera = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("inserisci N intero");
        int n = Integer.valueOf(tastiera.readLine());
        System.out.println("inserisci A intero");
        int a = Integer.valueOf(tastiera.readLine());

        do {

            a = a + 1;
            if(a % 2 == 1){
                System.out.println(a);
                n = n - 1;
            }
            
        } while (n > 0);
    }

    public static void es2() throws Exception{
        BufferedReader tastiera = new BufferedReader(new InputStreamReader(System.in));
        int n, somma = 0;
        do {
            System.out.println("inserire un numero");
            n=Integer.valueOf(tastiera.readLine());
            somma += n;
        } while (somma != 0);
        System.out.println("la somma è diventata " + somma);
    }

    public static void es3(){
        int n = 0;
        int i;
        for(i = 0; i<100; i++){
            n++;
            System.out.print(n + " ");
        }
    }
}
