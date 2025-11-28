package Object;

import java.util.ArrayList;
import java.util.List;

public class Order {
    List<Dish> items = new ArrayList<>();

    public Order(List<Dish> items) {
        this.items = items;
    }

    public double getTotalPrice(){
        return items.stream().mapToDouble(Dish::getPrice).sum();
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();

        sb.append("Order:\n");

        items.forEach(d ->
                sb.append("- ")
                        .append(d.getName())
                        .append(": ")
                        .append(String.format("%.2f", d.getPrice()))
                        .append("€: ")
                        .append("\n")
        );

        return sb.toString();
    }
}
