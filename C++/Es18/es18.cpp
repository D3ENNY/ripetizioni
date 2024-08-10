#include<iostream>

//scrivere un programma che stampi i primi 50 numeri pari

int main(){
    int cnt = 0, i=0;;

    while(cnt < 50){
        if(i%2==0){
            cnt ++;
            std::cout << cnt << ") " << i << std::endl;
        }
        i++;
    }
}