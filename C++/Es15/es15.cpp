#include <iostream>

//dati in input 3 numeri, stampi la somma dei quadrati dei due minori

int main() {
    int a, b, c;
    int min1, min2;

    std::cout << "Inserisci tre numeri: " << std::endl;
    std::cin >> a >> b >> c;

    if (a > b && a > c) {
        min1 = b;
        min2 = c;
    } else if (b > a && b > c) {
        min1 = a;
        min2 = c;
    } else {
        min1 = a;
        min2 = b;
    }

    int somma = (min1^2) + (min2^2);

    std::cout << "La somma del quadrato dei due numeri minori è: " << somma << std::endl;
}
