#include<iostream>
#include<cmath>

int main(){
    int a, b, c;
    int min1, min2;
    int tot;

    std::cout << "Inserisci tre numeri: " << std::endl;
    std::cin >> a >> b >> c;

    if(a>b&& a>c){
        min1=b;
        min2=c;
        
    } else if(b>a&& b>c){
        min1=a;
        min2=c;

    }else {
        min1=a;
        min2=b;
    }
    tot=pow(min1,2)+ pow(min2,2);
    std::cout<<tot;


}