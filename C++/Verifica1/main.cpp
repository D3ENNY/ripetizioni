#include<iostream>
#include<string>

bool isInteger(const std::string& number){

    if(number.empty()) return false;

    int start = (number[0] == '+' || number[0] == '-') ? 1 : 0;

    for(int i=start; i<number.length(); i++)
        if (!isdigit(number[i]))
            return false;

    return true;
}

int main() {

    std::cout << "Esercizio numero 1" << std::endl;
    std::cout << "Dato un numero N in input, stampare tutti i numeri da N a 1 come se fosse un conto alla rovescia\n" << std::endl;

    int n;
    std::cout << "inserire un numero n: " << std::endl;
    std::cin >> n;

    for (int i=n; i>=1; i--)
        std::cout << i << " ";


//----------------------------------------------------------------------------------//


    std::cout << "\n\nEsercizio numero 2" << std::endl;
    std::cout << "Dati due numeri in input, contare quanti numeri pari ci sono e quanti dispari tra i due estremi (non compresi)\n" << std::endl;

    int a, b, min, max, even = 0, shots = 0;

    std::cout << "inserire un numero a: " << std::endl;
    std::cin >> a;
    std::cout << "inserire un numero b: " << std::endl;
    std::cin >> b;

// scelto di far così perchè l'esercizio non dice dato a > b quindi faccio io il controllo di quale è il maggiore e quale il minore,
// le due variabili extra sono solo per far capire meglio il codice ma sono totalmente superflue
    if (a < b){
        min = a;
        max = b;
    }else{
        min = b;
        max = a;
    }

    for(int i=min+1; i<max; i++)
        if(i%2 == 0)
            even++;
        else 
            shots++;

    std::cout << "nell'intervallo " << a << " - " << b << " sono presenti " << even << " numeri pari e " << shots << " numeri dispari";


//----------------------------------------------------------------------------------//


    std::cout << "\n\nEsercizio numero 3" << std::endl;
    std::cout << "Dato un valore X e una sequenza indefinita di numeri che termina con \'0\' trovare la somma dei numeri nella sequenza che sono pari e inferiori a X\n" << std::endl;

    int x, num, tot = 0;

    std::cout << "Inserire un numero X: ";
    std::cin >> x;

    do{
        std::cout << "\nInserire un numero che termina per 0;\nSrivere il numero \'0\' se vuoi finire la sequenza: ";
        std::cin >> num;

        if(num <= x && num % 2 == 0 && num % 10 == 0)
            tot += num;

    }while(num != 0);

    std::cout << "La somma dei numeri della sequenza è: " << tot << std::endl;


//----------------------------------------------------------------------------------//


    std::cout << "\n\nEsercizio numero 4" << std::endl;
    std::cout << "Dato un numero in input, intero, senza nessun limite di grandezza stampare il contrario di esso\n" << std::endl;

    std::string number;
    std::string reverse1;
    std::string reverse2;


    std::cout << "inserire un numero n" << std::endl;
    std::cin >> number;

    //questo controllo lo ho fatto solo per scrupolo, non era richiesto nella richiesta del programma, 
    //ma è per evitare che l'utente possa inserire qualcosa che non sia un numero
    if(!isInteger(number)){
        std::cout << "l'input non è un numero" << std::endl;
        return 1;
    }

    reverse1 = std::string(number.rbegin(), number.rend());
    std::cout << "Metodo 1) Il numero " << number << " scritto al contrario è: " << reverse1 << std::endl;

    for(int i=number.length(); i>=0 ; i--)
        reverse2 += number[i];

    std::cout << "Metodo 2) Il numero " << number << " scritto al contrario è: " << reverse2 << std::endl;

    return 0;
}