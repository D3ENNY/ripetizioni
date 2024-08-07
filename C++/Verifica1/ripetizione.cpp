#include<iostream>
#include<string>

int main() {

    int n;

    std::cout << "inserire un numero N: ";
    std::cin >> n;

    for(int i = n; i>=0; i--){
        std::cout << i << " - ";
    }



    // 1. prendere in input 2 numeri
    // 2. preparare due variabili una per i pari e una per i dispari
    // 3. prendere tutti i numeri tra x e y  es => 5 e 10 - 5 6 7 8 9 10
    // 4. rimuovere gli estremi es => 5 e 10 - 6 7 8 9
    // 5. contare i pari e i dispari
    // 6. stampare il risultato

    // + - * / ^ %

    int x, y, pari = 0, dispari = 0;

    std::cout << "inserire un numero X minire di Y (da inserire dopo): ";
    std::cin >> x;

    std::cout << "\ninserire un numero Y: ";
    std::cin >> y;

    for(int i=x+1; i<y; i++){
        if(i % 2 == 0){
            pari ++;
        } else {
            dispari++;
        }
    }

    std::cout << "nell'intervallo " << x << " - " << y << " sono presenti " << pari << " numeri pari e " << dispari << " numeri dispari";



    // int x;

    // std::cout << "Inserire un numero X: ";        
    // std::cin >> x;

    // while(x == 4){   // VIENE ESEGUITO SOLO SE X È UGUALE A 4 E IN CASO RIMANE DENTRO
    //     std::cin >> x;
    // }

    // do {
    //     std::cin >> x;
    // }while(x == 4); // ALMENO UNA VOLTA VIENE ESEGUITO E RIMANE DENTRO SE X È UGUALE A 4


    std::cout << "\n\nEsercizio numero 3" << std::endl;

    int num, tot = 0;

    std::cout << "Inserire un numero X: ";
    std::cin >> x;

    do{
        std::cout << "\ninput numero: ";
        std::cin >> num;

        if(num < x && num % 10 == 0 && num % 2 == 0){
            tot = tot + num;
        }

    }while(num != 0);

    std::cout << tot;

    std::string str = "1234";

    for(int i = str.length(); i >= 0; i--){
        std::cout << str[i];
    }
    std::cout << "" << std::endl;

    std::cout << std::string(str.rbegin(), str.rend());
}

/**
 * @and - &&
 * 
 *  V V | V 
 *  V F | F
 *  F V | F
 *  F F | V
 * 
 * @OR - ||
 * 
 *  V V | V
 *  V F | V
 *  F V | V
 *  F F | F
 * 
 */