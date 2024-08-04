#include<iostream>

// stampa la media di tre numeri

int main(){
    int a,b,c,avg;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> a;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> b;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> c;

    avg = (a+b+c) / 3;

    std::cout << "la media dei tre numeri è: " << avg << std::endl;

}