#include<iostream>

//inserire un prgogramma che prenda in input N numeri, e stampi solo la somma di quelli dispari

int main(){
    int n, val, sum=0;

    std::cout << "Inserire quanti numeri vuoi inserire: ";
    std::cin >> n;

    for (int i=0; i<n; i++){
        std::cout << "\nInserire un numero: ";
        std::cin >> val;

        if(val%2!=0)
            sum += val;
    }

    std::cout << "La somma dei numeri dispari è: " << sum << std::endl;
    
}