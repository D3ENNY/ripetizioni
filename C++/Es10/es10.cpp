#include<iostream>

// dati in input ore, minuti e secondi, calcolarne il tempo totale in secondi

int main() {
    const int BASE_60 = 60; 
    int hour, minutes, seconds, totSec;

    std::cout << "Inserire ore: ";
    std::cin >> hour;
    std::cout << "Inserire minuti: ";
    std::cin >> minutes;
    std::cout << "Inserire secondi: ";
    std::cin >> seconds;

    // sappiamo che in un ora sono presenti 3600 secondi
    // sappiamo che in un minuto sono presenti 60 secondi
    totSec = (hour * BASE_60^2) + (minutes * BASE_60) + seconds;

    std::cout << "il totale dei secondi sono: " << totSec << std::endl;
}