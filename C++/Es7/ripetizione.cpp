#include<iostream>

int main(){
    //dati due variabili A e B, invertire i loro valori senza perderne il valore

    int a = 10;
    int b = 5;
    int tmp;

    tmp = a;
    a = b;
    b = tmp;

    std::cout << "a: " << a << " b: " << b;
}