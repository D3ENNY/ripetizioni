import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import Object.*;

public class Main {

    static Scanner sc = new Scanner(System.in);

    void main() throws IOException {
        int choise = -1;

        List<Dish> menu = caricaMenu();

        do {
            System.out.println("""
                    1. Visualizza menù
                    2. Nuova comanda
                    3. Enter admin panel
                    """);
            choise = sc.nextInt();

            switch(choise){
                case 1 -> visualizzaMenu(menu);
                case 2 -> nuovaComanda(menu);
            }

        }while (choise != 4);
    }

    private List<Dish> caricaMenu() throws IOException {
        BufferedReader br = new BufferedReader(new FileReader(new File("Menu.txt")));
        List<Dish> menu = new ArrayList<>();
        String line;

        while((line = br.readLine()) != null){
            menu.add(new Dish(line.split(":")[0].trim(), Double.parseDouble(line.split(":")[1].replace("€", "").trim())));
        }
        return menu;
    }

    private void visualizzaMenu(List<Dish> menu) {
        menu.forEach(x -> System.out.printf("Prodotto: %s | %.2f€%n",x.getName(), x.getPrice()));
    }

    private Order nuovaComanda(List<Dish> menu) {
        boolean flag = false;
        List<Dish> items = new ArrayList<>();

        do {
            System.out.println("che piatto si vuole aggiungere all'ordine?\n segnare il nome");
            String nameDish = sc.nextLine();

            Dish dish = menu.stream().filter(x -> x.getName().equals(nameDish)).findFirst().orElse(null);
            if(dish == null){
                System.out.println("piatto non trovato");
                break;
            }
            items.add(dish);

            System.out.println("si vuole ordinare altro? si/no");
            String choise = sc.nextLine();
            flag = choise.toLowerCase(Locale.ROOT).trim().equals("si");

        }while (flag);

        Order order = new Order(items);

    }
}
