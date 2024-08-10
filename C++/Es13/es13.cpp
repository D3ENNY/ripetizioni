#include<iostream>

// dato in input il numero del mese, stampari quanti giorni ha

int main() {
    int month;

    std::cout << "Inserisci un numero corrispondente al mese:\n1 = Gennaio\n2 = Febbraio" << std::endl;
    std::cin >> month;

    std::cout << "il mese " << month << " ha giorni: ";

    switch(month){
        case 1:
            std::cout << 31;
            break;
        case 2:
            std::cout << 28;
            break;
        case 3:
            std::cout << 31;
            break;
        case 4:
            std::cout << 30;
            break;
        case 5:
            std::cout << 31;
            break;
        case 6:
            std::cout << 30;
            break;
        case 7:
            std::cout << 31;
            break;
        case 8:
            std::cout << 31;
            break;
        case 9:
            std::cout << 30;
            break;
        case 10:
            std::cout << 31;
            break;
        case 11:
            std::cout << 30;
            break;
        case 12: 
            std::cout << 31;
            break;
        default:
            std::cout << month << " non è un mese valido" << std::endl;
            
    }

}