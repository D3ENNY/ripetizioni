#include<iostream>

// giocare con input, output e con i tipi della variabili

int main() {
    std::cout << "Parte 1" << std::endl;
    int n = 5;
    std::cout << n << std::endl;
    std::cout << "inserire un numero: " << std::endl;
    std::cin >> n;
    std::cout << n << std::endl;

    std::cout << "Parte 2" << std::endl;
    float fn = 2.3;
    std::cout << fn << std::endl;
    std::cout << "inserire un numero: " << std::endl;
    std::cin >> fn;
    std::cout << fn << std::endl;

    std::cout << "Parte 3" << std::endl;
    char c = '+';
    std::cout << c << std::endl;
    std::cout << "inserire un carattere: " << std::endl;
    std::cin >> c;
    std::cout << c << std::endl;

    std::cout << "Parte 4" << std::endl;
    std::string str = "Ciao! mondo";
    std::cout << str << std::endl;
    std::cout << "inserire una frase: " << std::endl;
    std::cin >> str;
    std::cout << str << std::endl;

    return 0;
}