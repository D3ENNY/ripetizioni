#include<iostream>

void stampaArray(int arr[], int size){
    for (int i = 0; i < size; i++) {
        std::cout << arr[i] << " ";
    }
    std::cout << std::endl;
}

int main(){
    int arr[5];
    int pos, newValue;

    std::cout << "inserire 5 numeri" << std::endl;

    for(int i=0; i<5; i++){
        std::cin >> arr[i];
    }

    stampaArray(arr, 5);

    std::cout << "inserire la posizione da modificare" << std::endl;
    std::cin >> pos;

    if(pos > 0 && pos < 5){
        std::cout << "inserire il nuovo valore" << std::endl;
        std::cin >> newValue;

        arr[pos-1] = newValue;

        stampaArray(arr, 5);
    }

}