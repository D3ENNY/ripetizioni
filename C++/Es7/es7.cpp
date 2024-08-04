#include<iostream>

int main() {
    char a = 'a', b = 'b', tmp;

    std::cout << "a: " << a << " b: " << b << std::endl;

    tmp = a;
    a = b;
    b = tmp;

    std::cout << "a: " << a << " b: " << b << std::endl;
}