#include<iostream>
using namespace std;

int main(){
    int altezza,lunghezza,perimetro, area;
    cout<<"inserisci altezza" <<endl;
    cin>>altezza;
    cout<<"inserisci lunghezza" <<endl;
    cin>>lunghezza;
    perimetro= (altezza*2)+(lunghezza*2);
    area=altezza*lunghezza;
    cout<<"area: " << area <<"\nperimetro: "<< perimetro<< endl; 

    return 0;
}
