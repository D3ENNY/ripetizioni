#include <iostream>

// la variabile x è stata passata per riferimento || la variabile z per valore
// la variabile x essendo passata per riferimento va a far riferimento alla porzione di memoria della vaiabile iniziale (quella passata dal main)
// la variabile z essendo passata per valore si ritrova al suo interno una COPIA della variabile originale
void test(int &x, int z){
    std::cout << "x: " << &x << std::endl;
    std::cout << "z: " << &z << std::endl;
}

void test2(int &x, int z){
    std::cout << "x1: " << x << std::endl;
    std::cout << "z1: " << z << std::endl;
    
    x = 100;
    z = 1000;
    
    std::cout << "x1.1: " << x << std::endl;
    std::cout << "z1.1: " << z << std::endl;
}

int main()
{
    int inizio = 5;
    
    std::cout << "inizio: " << &inizio << std::endl;
    
    test(inizio, inizio);
    
    std::cout << "inizio 2: " << inizio << std::endl;
    test2(inizio, inizio);
    std::cout << "inizio 2.1: " << inizio << std::endl;

    return 0;
}