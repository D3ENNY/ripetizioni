#include <iostream>

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
