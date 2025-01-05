import java.util.Scanner;

public class App {

    static Scanner sc = new Scanner(System.in);
    public static void main(String[] args) {

        App app = new App();
        boolean flag = true;
        do{
            System.out.println("inserire un esercizio da 1 a 7");
            switch(sc.nextInt()){
                case 1:
                {
                    app.es1();
                    break;
                }
                case 2:
                {
                    app.es2(new int[] {0,1,4,0,0,7,0,3});
                    break;
                }
                case 3:
                {
                    app.es3();
                    break;
                }
                case 4:
                {
                    app.es4();
                    break;
                }
                case 5:
                {
                    app.es5(new int[] {0,1,4,0,0,7,0,3});
                    break;
                }
                case 6:
                {
                    app.es6();
                    break;
                }
                case 7:
                {
                    System.out.println(app.es7(new int[] {3,4}));
                    break;
                }
            }

        }while(flag);
    }

    private void printArr(int[] array){
        for (int i : array)
            System.out.printf("%d, ",i);
        System.out.println("\n");
    }

    private void es1(){
        int n, m, sum = 0;
        System.out.println("inserire un numero positivo \'n\'");
        n = sc.nextInt();
        System.out.println("inserire un numerio positivo \'m\'");
        m = sc.nextInt();
        if(n >= 0 && m >= 0){
            int max, min;
            if(n > m){
                max = n;  
                min = m;  
            }else{
                max = m;
                min = n;
            }
            for (int i = min; i <= max; i++)
                if(i%3==0)
                    sum += i;
        }else System.out.println("devi inserire due numeri positivi");
        System.out.printf("la somma è %d%n%n", sum);
    }

    private void es2(int[] array){
        for (int i = 1; i < array.length; i++)
            if(array[i] == 0)
                array[i] = array[i-1];
        
        printArr(array);
    }

    private void es3(){
        System.out.println("la difficoltà computazionale dello scorso codice è O(n) dove n è la lunghezza dell'array preso in input, esso perchè l'algoritmo esegue un singolo passaggio attraverso l'array mantenendo il numero di informazioni costante");
    }

    private void es4() {
        System.out.println("the silent is golden");
    }

    private void es5(int[] array){
        int[] array2 = new int[array.length];
        for (int i = 1; i < array.length; i++)
        if(array[i] == 0){
            for (int j = i; j >= 0; j--)
                if(array[j] != 0){
                    array2[i] = array[j];
                    break;
                }
        }else array2[i] = array[i];
        printArr(array2);
    }

    private void es6(){
        byte b = 100;
        b += 50;
        System.out.println(b + "\n");
        System.out.printf("il risultato stampato \"%d\" è dato dal fatto che una variabile byte ha un range da un minimo di -128 ad un massimo di 127 compresi. ciò significa che sommando 50 a 100 il valore supera il range totale, essendo 150 > 127%nquindi abbiamo bisogno di un overflow per riporare tale dato all'interno del rage, essendo byte un valore con max 127, noi avremo un overflow di 128, quindi faremo:%n150 - 128 = 22, successivamente quindi -128 + 22 = -106%n", b);
    }

    private int es7(int[] a) {
        if (a.length == 0)
            return 0;
        else {
        int[] b = dropFirst(a);
        return a[0] + es7(b);
         
        }
    }

    private int[] dropFirst(int[] a) {
        if (a.length == 0)
            return a;

        var res = new int[a.length - 1];

        for (int i = 0; i< res.length; i++) {
            res[i] = 2 * a[i+1];
            System.out.println("-->"+res[i]);
        }
        return res;
    }

}
