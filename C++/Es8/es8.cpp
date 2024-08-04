#include<iostream>

// dati due numeri in input, stamparli in ordine crescente

int main() {
    int a, b;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> a;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> b;

    if (a > b)
        std::cout << "numeri in ordine crescente: " << b << " - " << a << std::endl;
    else
        std::cout << "numeri in ordine crescente: " << a << " - " << b << std::endl;
}