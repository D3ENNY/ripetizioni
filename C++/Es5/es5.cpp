#include<iostream>

// dato un intervallo A-B dire se ci sono più numeri positivi o negativi

int main(){
    int a,b, even = 0, shots = 0;

    std::cout << "inserire due numeri A e B con A < B\ninserire il numero A: ";
    std::cin >> a;

    do{
        std::cout << "inserire il numero B: ";
        std::cin >> b;
    }while(a>b);

    for (int i=a; i<=b; i++)
        if (i % 2 == 0)
            even++;
        else 
            shots++;
    
    if (even > shots)
        std::cout << "nell'intervallo " << a << " - " << b << " ci sono più numeri pari";
    else if (even == shots)
         std::cout << "nell'intervallo " << a << " - " << b << " ci sono tanti numeri pari quanti i dispari";
    else if (even < shots)
        std::cout << "nell'intervallo " << a << " - " << b << " ci sono meno numeri pari";
}