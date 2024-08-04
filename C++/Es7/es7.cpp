#include<iostream>

// scambiare due variabili senza perderne il loro valore

int main() {
    char a = 'a', b = 'b', tmp;

    std::cout << "a: " << a << " b: " << b << std::endl;

    tmp = a;
    a = b;
    b = tmp;

    std::cout << "a: " << a << " b: " << b << std::endl;
}