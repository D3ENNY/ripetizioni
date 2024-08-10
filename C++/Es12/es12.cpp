#include<iostream>

//scrivere se un anno preso in input è bisestile
// tip: un anno è sicuramente bisestibile se è divisibile per 400, o sennò se è divisibile per 4 ma non per 100

int main(){

    int year;

    std::cout << "inserire un anno: ";
    std::cin >> year;

    if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        std::cout << "\nL'anno è bisestile";
    else
        std::cout << "\nL'anno non è bisestile";

}