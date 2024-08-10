#include<iostream>

//fare un programma che calcoli se un triangolo è reale, scaleno, equilatero, isoscele, rettangolo,

/**
 * un triangolo è scaleno se tutti i lati sono diversi
*/
bool scalene(int triangle[3]) {
    return (triangle[0] != triangle[1]) && 
           (triangle[1] != triangle[2]) &&
           (triangle[0] != triangle[2]);
}

/**
 * un triangolo è equilatero quando tutti i suoi lati sono uguali
*/
bool equilateral(int triangle[3]){
    return triangle[0] == triangle[1] && triangle[1] == triangle[2];
}

/**
 * un triangolo è isoscele quando almeno 2 lati sono uguali
*/
bool isosceles(int triangle[3]){
return (triangle[0] == triangle[1]) ||
       (triangle[1] == triangle[2]) ||
       (triangle[0] == triangle[2]);
}

/**
 * un triangolo è rettangolo quando soddisfa 3 condizioni: 
 *
 * 1. a^2+b^2=c^2
 * 2. a^2+c^2=b^2
 * 3. b^2+c^2=a^2
 *
*/
bool rectangle(int triangle[3]){
    return (triangle[0]^2 + triangle[1]^2 == triangle[2]^2) &&
           (triangle[0]^2 + triangle[2]^2 == triangle[1]^2) &&
           (triangle[1]^2 + triangle[2]^2 == triangle[0]^2);
}

/**
 * un triangolo è reale quando soddisfa 3 condizioni: 
 *
 * 1. a+b>c
 * 2. a+c>b
 * 3. b+c>a
 *
*/
bool real(int triangle[3]){
    return (triangle[0] + triangle[1] > triangle[2]) && 
           (triangle[0] + triangle[2] > triangle[1]) && 
           (triangle[1] + triangle[2] > triangle[0]);
}

int main(){

    int traingle[3];
    std::cout << "Inserire i 3 lati di un triangolo" << std::endl;

    for (int i=0; i<3; i++)
        std::cin >> traingle[i];

    if(!real(traingle)){
        std::cout << "Le misure non formano un triangolo reale" << std::endl;
        return 1;
    } 
    std::cout << "Le misure formano un triangolo reale" << std::endl;


    if(equilateral(traingle))
        std::cout << "Le misure formano un triangolo equilatero" << std::endl;

    if(isosceles(traingle))
        std::cout << "Le misure formano un triangolo isoscele" << std::endl;

    if(scalene(traingle))
        std::cout << "Le misure formano un triangolo scaleno" << std::endl;

    if(rectangle(traingle))
        std::cout << "Le misure formano un triangolo rettangolo" << std::endl;

}