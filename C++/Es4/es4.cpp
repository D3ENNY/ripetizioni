#include<iostream>
#include <vector>

// dire se un numero preso in input è un numero perfetto

int main() {
    int n, sum = 0;
    std::vector<int> divisor;
    std::cout << "inserire un numero positivo in input: ";
    std::cin >> n;

    for (int i=1; i<=n/2; i++)
        if (n % i == 0)
            divisor.push_back(i);
    
    for (int i=0; i<divisor.size(); i++)
        sum += divisor[i];

    if(sum == n)
        std::cout << "il numero " << n << " è un numero perfetto" << std::endl;
    else 
        std::cout << "il numero " << n << " non è un numero perfetto" << std::endl;
    
//     for (int i=0; i<divisor.size(); i++)
//         std::cout << divisor[i] << " ";
//     std::cout << std::endl;
}