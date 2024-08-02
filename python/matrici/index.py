arr = [] # [1,2,3,4] 
matrice = [] # [[1,2,3], [1,2,3]] 
# matrice = [[0 for _ in range(4)] for _ in range(4)]
# print(matrice)

# METODI ARRAY 

print("---SPIEGAZIONE ARRAY---")
for i in range(0,10):
    arr.append(i) # push to array    
    
print(arr)

# FUNZIONI

def stampa_matrice(matrice):
    for i in range(0, len(matrice)):
        print(matrice[i])

# ESERCIZIO MATRICE

n = int(input("\ninserire lato matrice: "))

print("\n----ESERCIZIO 1----")

for i in range(0, n):
    matrice.append([])
    if i % 2 == 0:
        for _ in range(0, n):
            matrice[i].append(1)
    else: 
        for _ in range(0, n):
            matrice[i].append(0) 
            
        
stampa_matrice(matrice)

print("\n############# GHE SBORO #############")

print("\n---ESERCIZIO 1.2---")

val = 0
matrice = []

for i in range(n):
    matrice.append([])
    val = val + 1 if i % 2 == 0 else val - 1

    for _ in range(0, n):
        matrice[i].append(val)
        
stampa_matrice(matrice) 

print("\n############# GHE SBORO #############")

print("\n---ESERCIZIO 2---")

matrice = []
for i in range(n):
    matrice.append([])

    if i % 2 == 0: 
        for _ in range(n):
            lenght = len(matrice[i])
            if lenght % 2 == 0:
                matrice[i].append(0)
            else:
                matrice[i].append(1)
                
    else: 
        for _ in range(n):
            lenght = len(matrice[i])
            if lenght % 2 != 0:
                matrice[i].append(0)
            else:
                matrice[i].append(1)
            
stampa_matrice(matrice)

print("\n############# GHE SBORO #############")

print("\n---ESERCIZIO 2.2---")
matrice = []

for i in range(n):
    matrice.append([0 for i in range(n)])
    val = 0 if i % 2 == 0 else 1
    for index in range(n):
        matrice[i][index] = val
        if val == 0: 
            val = 1
        else:
            val = 0
            

stampa_matrice(matrice)