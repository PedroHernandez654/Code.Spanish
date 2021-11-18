listanombres = []
numeros = []
for x in range(5):
    print("Ingrese El nombre: ")
    nombre=input()
    listanombres.append(nombre)
for x in range (5):
    print("mi nombre es: " + str(listanombres[x]))
print("************************************************************")
for x in range(0, 100):
    if x%2!=0:
        numeros.append(x)


for x in range(len(numeros)):
    print(numeros[x])

    #tienen que insertar 5 nombres, pidiendo 5 nombres
    #luego poner edades impares, en la expresion lista de edad
