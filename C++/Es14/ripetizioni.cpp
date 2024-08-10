#include<iostream>

int main(){
    double tot, prezzoFinale;

    std::cout << "Inserisci il totale della spesa: ";
    std::cin >> tot;

    if(tot>100){
        prezzoFinale= tot-(tot*0.20);
    }else{
        prezzoFinale=tot;

    }
    std::cout<<prezzoFinale;

}