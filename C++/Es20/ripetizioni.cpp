#include<iostream>

int main(){
    int n;
    std::cout<<"inserisci la lunghezza" << std::endl;
    std::cin >> n;

    int arr[n]; // n=5 -> array lungo 4 perchè si parte da 0

    for(int i=0; i<n; i++){
        std::cin >> arr[i];
    }

    for (int i = 0; i < n; i++) 
        std::cout << arr[i] << " ";

    for(int i=0; i<n; i++){
        if(arr[i] % 2 == 0){
            arr[i]++;
        }else{
            arr[i]--;
        }
    }

    for (int i = 0; i < n; i++) 
        std::cout << arr[i] << " ";
}