#include<iostream>

// data in input la quantità di numeri da prendere in input, calcolarne la somma complessiva

int main(){
    int n, val, tot=0;

    std::cout << "Inserire quanti numeri vuoi inserire: ";
    std::cin >> n;
    
    for (int i=0; i<n; i++){
        std::cout << "\nInserire un numero: ";
        std::cin >> val;
        tot += val;
    }

    std::cout << "La somma di tutti i numeri è: " << tot << std::endl;
}