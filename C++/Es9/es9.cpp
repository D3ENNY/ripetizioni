#include<iostream>

// stampare se un numero è dispari o pari

int main() {
    int a;

    std::cout << "inserire un numero:" << std::endl;
    std::cin >> a;

    if (a % 2 == 0)
        std::cout << "il numero \"" << a << "\" è pari";
    else 
        std::cout << "il numero \"" << a << "\" è dispari";
}