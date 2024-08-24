#include<iostream>

// crea un vettore di 5 elementi inseriti dall'utente e stampane il valore
//successivamente chiedi all'utente la posizione dell'elemento da modificare, e se esiste, ristampa l'array col nuovo elemento

// Funzione per stampare un array
void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;
}

int main() {
    const int SIZE = 5;
    int arr[SIZE];
    int pos, newValue;

    std::cout << "Inserisci " << SIZE << " numeri:" << std::endl;
    for (int i = 0; i < SIZE; i++) {
        std::cin >> arr[i];
    }

    std::cout << "Vettore inserito: ";
    printArray(arr, SIZE);

    std::cout << "Inserisci la posizione dell'elemento da modificare (1-" << SIZE << "): ";
    std::cin >> pos;

    // Verifica se la posizione è valida
    if (pos > 0 && pos <= SIZE) {
        std::cout << "Inserisci il nuovo valore: ";
        std::cin >> newValue;
        arr[pos - 1] = newValue; // Modifica l'elemento all'indice specificato

        std::cout << "Vettore modificato: ";
        printArray(arr, SIZE);
    } else
        std::cout << "Posizione non valida!" << std::endl;
    
    return 0;
}
