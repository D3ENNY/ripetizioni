import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import Object.*;

public class Main {

    static Scanner sc = new Scanner(System.in);
    static List<Dish> menu;

    void main() throws IOException {
        int choise = -1;

        menu = caricaMenu();

        do {
            System.out.println("""
                    1. Visualizza menù
                    2. Nuova comanda
                    3. Enter admin panel
                    4. exit
                    """);
            choise = sc.nextInt();

            switch (choise) {
                case 1 -> visualizzaMenu();
                case 2 -> nuovaComanda();
                case 3 -> adminPanel();
            }

        } while (choise != 4);
    }

    private List<Dish> caricaMenu() throws IOException {
        BufferedReader br = new BufferedReader(new FileReader(new File("Menu.txt")));
        List<Dish> menu = new ArrayList<>();
        String line;

        while ((line = br.readLine()) != null) {
            menu.add(new Dish(line.split(":")[0].trim(), Double.parseDouble(line.split(":")[1].replace("€", "").trim())));
        }
        return menu;
    }

    private void visualizzaMenu() {
        menu.forEach(x -> System.out.printf("Prodotto: %s | %.2f€%n", x.getName(), x.getPrice()));
    }

    private Order nuovaComanda() throws IOException {
        boolean flag = false;
        List<Dish> items = new ArrayList<>();

        BufferedWriter bw = new BufferedWriter(new FileWriter(new File("Order.txt"), true));
        sc.nextLine();
        do {
            System.out.println("che piatto si vuole aggiungere all'ordine?\n segnare il nome");
            String nameDish = sc.nextLine();

            Dish dish = menu.stream().filter(x -> x.getName().equals(nameDish)).findFirst().orElse(null);
            if (dish == null) {
                System.out.println("piatto non trovato");
                break;
            }
            items.add(dish);

            System.out.println("si vuole ordinare altro? si/no");
            String choise = sc.nextLine();
            flag = choise.toLowerCase(Locale.ROOT).trim().equals("si");

        } while (flag);

        Order order = new Order(items);

        bw.write(order.toString());

        return order;
    }

    private boolean adminPanel() throws IOException {
        sc.nextLine();
        System.out.println("inserire user");
        String user = sc.nextLine();
        System.out.println("inserire password");
        String password = sc.nextLine();

        if (!"admin".equals(user) || !"admin".equals(password)) {
            System.out.println("utente non autorizzato");
            return false;
        }

        int choise = -1;
        do {
            System.out.println("""
                    1. Visualizza menù
                    2. Nuovo prodotto
                    3. Rimozione prodotto
                    4. Fatturazione della giornata
                    5. exit
                    """);
            choise = sc.nextInt();

            switch (choise) {
                case 1 -> visualizzaMenu();
                case 2 -> nuovoProdotto();
                case 3 -> rimuoviProdotto();
                case 4 -> fatturazioneElettronica();
            }

        } while (choise != 5);

        return true;
    }

    private void fatturazioneElettronica() {
        
    }

    private void rimuoviProdotto() throws IOException {
        sc.nextLine();
        System.out.println("inserire nome prodotto da rimuovere");
        String name = sc.nextLine();

        menu.removeIf(x -> x.getName().equalsIgnoreCase(name));

        stampaProdotto();
    }

    private void nuovoProdotto() throws IOException {
        sc.nextLine();
        System.out.println("inserire nome prodotto");
        String name = sc.nextLine();
        System.out.println("inserire prezzo");
        double price = sc.nextDouble();

        menu.add(new Dish(name, price));
        stampaProdotto();
    }


    private void stampaProdotto() throws IOException {
        BufferedWriter bw = new BufferedWriter(new FileWriter(new File("Menu.txt")));
        StringBuilder sb = new StringBuilder();

        menu.forEach(x ->
                sb.append(x.getName())
                        .append(": ")
                        .append(String.format("%.2f", x.getPrice()))
                        .append("€")
                        .append("\n")
        );

        bw.write(sb.toString());

    }

}
