#include<iostream>

//creare un array di N numeri, e per ogni numero controllare se è pari o diaspari, in caso sia pari incrementa tale numeri di un unità, se invece è dispari decrementala

int main(){

    int n;

    std::cout << "Inserisci la dimensione dell'array: " << std::endl;
    std::cin >> n;

    int arr[n];

    std::cout << "Inserisci " << n << " numeri:" << std::endl;
    for (int i = 0; i < n; i++) 
        std::cin >> arr[i];

    for (int i = 0; i < n; i++) 
        if (arr[i] % 2 == 0) 
            arr[i]++; // Incrementa di uno se il numero è pari
         else 
            arr[i]--; // Decrementa di uno se il numero è dispari
        
    for (int i = 0; i < n; i++) 
        std::cout << arr[i] << " ";
}