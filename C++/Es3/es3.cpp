 #include<iostream>
 #include<format>

// calcolare perimetro ed area di un triangolo

 int main() {
    int larghezza, altezza, area, perimetro;

    std::cout << "Insarire la larghezza del rettangono: " << std::endl;
    std::cin >> larghezza;
    std::cout << "Insarire la altezza del rettangono: " << std::endl;
    std::cin >> altezza;

    area = altezza * larghezza;
    perimetro = (altezza * 2) + (larghezza * 2);

    std::cout << "il perimetro del rettangolo è: " + std::to_string(perimetro) + "\nl'area invece è:" + std::to_string(area) << std::endl;
    std::cout << "il perimetro del rettangolo è: " << perimetro << "\nl'area invece è:" << area << std::endl;
    std::cout << std::format("Il perimetro del rettagono è: {}\nl'area invece è: {}", perimetro, area) << std::endl;

    return 0;
 }