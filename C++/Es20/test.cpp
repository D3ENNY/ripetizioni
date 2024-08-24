#include<iostream>

int main(){
    // visto che si parte da 0, questo è un array di 4 elementi e non di 5 
    int arr[5] = {1,2,3,4,5}; 

    for(int i=0; i<5; i++){
        std::cout << arr[i] << " ";
    }
}