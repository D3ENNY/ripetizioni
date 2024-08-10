#include<iostream>

int main(){
    int n, val, sum=0;

    std::cout << "Inserire quanti numeri vuoi inserire: ";
    std::cin >> n;

    for (int i=0; i < n; i++)
    {
        std::cout<<"inserisci un numero ";
        std::cin>> val;
        if(val%2!=0)
            sum+=val;
    }

    std::cout<<sum;
    

    
    
}