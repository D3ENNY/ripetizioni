import java.io.*;
import java.util.Objects;
import java.util.Scanner;

class Main {

    static Scanner sc = new Scanner(System.in);

    public static void main(String[] args) throws IOException {

        File note = new File("note.txt");
        BufferedWriter writer = new BufferedWriter(new FileWriter(note, true));
        BufferedReader reader = new BufferedReader(new FileReader(note));

        if(note.exists()){
            System.out.println("il file è già presente!");
        }else{
            note.createNewFile();
        }

        System.out.println("\ninserire nota da salvare");
        String frase = sc.nextLine();

        writer.write(frase);
        writer.newLine();
        writer.flush();
        writer.close();

        System.out.println("Nota salvata!");

        System.out.println("\nlettura file in corso");
        String line;

        while((line = reader.readLine()) != null){
            System.out.println(line);
        }

        System.out.println("Vuoi sovrascrivere il file? si - no");
        String choise = sc.nextLine();

        if(choise.equals("si")){
            writer = new BufferedWriter(new FileWriter(note, false));

            System.out.println("inserire frase da sovrascrivere: ");
            writer.write(sc.nextLine());
            writer.newLine();
            writer.flush();
            writer.close();

        } else if (choise.equals("no")) {
            System.out.println("arrivederci!");
        }

    }
}