#include<iostream>

//divisivile per 400
//divisibile per 4 ma non per 100

int main(){

    int anno;
    std::cout << "inserire anno: ";
    std::cin >> anno;


    if(anno%400 == 0 || (anno%4==0 && anno%100!=0)){
        std::cout << "\nL'anno è bisestile";
    }else{
        std::cout << "\nL'anno non è bisestile";
    }

}