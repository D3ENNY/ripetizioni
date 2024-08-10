#include<iostream>

// dati 3 numeri in input, trovare il massimo il minimo di essi e calcolarne la differenza

int main(){
    int a,b,c, min, max, diff;

    std::cout << "inserire 3 numeri: ";
    std::cin >> a >> b >> c;

    // if(a > b)
    //     if(a > c)
    //         max = a;
    //     else
    //         max = c;
    // else if(b > c)
    //     max = b;
    // else 
    //     max = c;

    //massimo
    if (a > b && a > c) 
        max = a;
    else if (b > c) 
        max = b;
    else 
        max = c;

    //minimo
    if (a < b && a < c) {
        min = a;
    } else if (b < c) {
        min = b;
    } else {
        min = c;
    }

    diff = max - min;

    std::cout << "Il valor massimo è: " << max << "\nIl valor minimo è: " << min << "\nLa loro differenza è: " << diff << std::endl;
    

}