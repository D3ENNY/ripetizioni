#include<iostream>

int main() {
    // dati due numeri in input, stampare il maggiore

    int a,b, max;

    std::cout << "inserire un numero A: ";
    std::cin>>a;
    std::cout << "\ninserire un numero B: ";
    std::cin>>b;

    if(a>b){
        max = a;
    }else{
        max = b;    
    }

    std::cout << max;

}