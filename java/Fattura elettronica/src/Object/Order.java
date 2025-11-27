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
        return """
                ============
                *  ordine  *
                ============
                
                """;
    }
}
