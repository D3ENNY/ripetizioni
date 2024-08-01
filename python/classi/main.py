# OOP => Oriented Objected Programming
# ereditarietà __var => private || _var = protected || var = public
# polimorfismo
# incapsulamento

import second

class Persona:
    
    def __init__(self, name): 
        print("esegue il costruttore di Persona")
        self._name = name
        self.__lavorare() #chiamata a metodo privato
    
    def saluta(self): 
        print(f"ciao {self._name}")
        
    def __lavorare(self): 
        print(f"{self._name} sta lavorando")
        
    
       
class Studente(Persona): 
    def __init__(self, name, school_name):
        print("esegue il costruttore di Studente")
        super().__init__(name) # esegue il costruttore della classe madre
        self.__school_name = school_name
    
    def saluta(self): #overrite
        print(f"ciao, mi chiamo {self._name} e frequento la scuola {self.__school_name}")

if __name__ == '__main__': # ingresso principale programma
    
    p = Persona("Paolo")
    p.saluta()
    #p.__lavorare()
    
    print()
    
    s = Studente("Paolo", "Cornaro")
    s.saluta()
    
    print()
    
    classe_esterna = second.Second()
    classe_esterna.method()
    
