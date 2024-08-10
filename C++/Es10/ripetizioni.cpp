#include<iostream>

int main(){
    int ore, minuti, secondi, secondiTot;

    std::cout << "Inserire ore: ";
    std::cin >> ore;
    std::cout << "Inserire minuti: ";
    std::cin >> minuti;
    std::cout << "Inserire secondi: ";
    std::cin >> secondi;

    secondiTot=(ore*3600)+(minuti*60)+secondi;

    std::cout<<secondiTot;
}