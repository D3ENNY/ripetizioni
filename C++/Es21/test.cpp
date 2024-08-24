#include<iostream>

void somma(int a, int b){
    std::cout<< a+b << std::endl;
} 

int sottrazione(int a, int b){
    return a-b;
}

int main(){
    somma(4,5);
    somma(7,8);

    std::cout << sottrazione(5,4) << std::endl;
    int a = sottrazione(7,2);
    std::cout << a << std::endl;
}