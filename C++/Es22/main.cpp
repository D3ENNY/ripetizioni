#include<iostream>
#include <cstdlib>
#include<ctime>
#include <iomanip> 

// dato un vettore di 7 element casuali generati tra 0 e 20, ricavare il massimo valore e la sua posizione e la media con la virgola

// Funzione per stampare un array
void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;
}

void maxValue(const int arr[], int SIZE, int &max, int &maxPos){
    max = arr[0];
    maxPos = 0;
    for (int i = 1; i < SIZE; i++)
        if(arr[i] > max){
            max = arr[i];
            maxPos = i;
        }
}

float averange(const int arr[], int size){
    int sum = 0;

    for (int i = 0; i < size; i++)
        sum += arr[i];

    return (float)sum / size;
    
}

int main(){
    const int SIZE = 7;
    int arr[SIZE];
    int max, maxPos;

    srand(time(NULL));
    
    for (int i = 0; i < SIZE; i++) 
        arr[i] = rand() % 21;

    printArray(arr, SIZE);

    maxValue(arr, SIZE, max, maxPos);

    std::cout << "Valore massimo: " << max << std::endl;
    std::cout << "Posizione del valore massimo: " << maxPos << std::endl;

    // Stampa la media con precisione di due decimali
    std::cout << std::fixed << std::setprecision(2);
    std::cout << "Media: " << averange(arr, SIZE) << std::endl;

}