#include <iostream>

// scontare del 20% il prezzo totale, solo se supera i 100€ e stamparne il risultato

int main() {
    double tot, endPrice;

    std::cout << "Inserisci il totale della spesa: ";
    std::cin >> tot;

    if (tot > 100) {
        endPrice = tot - ((tot - 100) * 0.20);
    } else {
        endPrice = tot;
    }

    std::cout << "Il prezzo da pagare è: " << endPrice << "€" << std::endl;
}
