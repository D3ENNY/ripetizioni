arr = [] # [1,2,3,4] 
matrice = [] # [[1,2,3], [1,2,3]] 
# matrice = [[0 for _ in range(4)] for _ in range(4)]
# print(matrice)

# METODI ARRAY 

for i in range(0,10):
    arr.append(i) # push to array    
    
# print(arr)

# ESERCIZIO MATRICE

n = input("inserire lato matrice: ")
val = 0

for i in range(0, int(n)):
    matrice.append([])
    if i % 2 == 0:
        for _ in range(0, int(n)):
            matrice[i].append(1)
    else: 
        for _ in range(0, int(n)):
            matrice[i].append(0) 
            
        
for i in range(0, len(matrice)):
    print(matrice[i])

print("############# GHE SBORO #############")

matrice = []
i = 0
for i in range(int(n)):
    matrice.append([])
    
    if i % 2 == 0: 
        for _ in range(int(n)):
            lenght = len(matrice[i])
            if lenght % 2 == 0:
                matrice[i].append(0)
            else:
                matrice[i].append(1)
                
    else: 
        for _ in range(int(n)):
            lenght = len(matrice[i])
            if lenght % 2 != 0:
                matrice[i].append(0)
            else:
                matrice[i].append(1)
            
for i in range(0, len(matrice)):
    print(matrice[i])