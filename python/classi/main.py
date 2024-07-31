# OOP => Oriented Objected Programming
# ereditarietà __var => private || _var = protected || var = public
# polimorfismo
# incapsulamento


class Persona:
    
    def __init__(self, name): 
        print("esegue il costruttore di Persona")
        self._name = name
    
    def saluta(self): 
        print(f"ciao {self._name}")
        
    
       
class Studente(Persona): 
    def __init__(self, name, school_name):
        print("esegue il costruttore di Studente")
        super().__init__(name) # esegue il costruttore della classe madre
        self.__school_name = school_name
    
    def saluta(self): #overrite
        print(f"ciao, mi chiamo {self._name} e frequento la scuola {self.__school_name}")

if __name__ == '__main__':
    
    p = Persona("Paolo")
    p.saluta()
     
    
    s = Studente("Paolo", "Cornaro")
    s.saluta()
    
    # FORMATTED STRING
    str1 = "ciao"
    str2 = "Paolo"
    
    print()
    print(str1 + " " + str2)
    print(f"{str1} {str2}")
    print("%s %s" % (str1, str2))
    print("{} {}".format(str1, str2))
    print(str1[::-1])