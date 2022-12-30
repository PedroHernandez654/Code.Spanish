#lista de string o str
##################0######1#######2####
listanombres = ["Pedro", "Manuel", "Jesus"]
#lista de int o enteros
listaedad = [12, 30, 25]

print(listanombres[1])

#como puedo saber el tamaño de mi lista
#print(len(listanombres + listaedad))
for x in range(len(listanombres)):
    print("mi nombre es: " + str(listanombres[x]) + " mi edad es: " + str(listaedad[x]))
#len nos dice el numero de elementos que tiene la lista
#range es un rango de 20?
#***************************************
#Esto es para insertar una cosa en el codigo
listanombres = ["victor", "manuel", "jesus"]
listaedad = [12, 30, 25]
for x in listanombres:
    print(x)
for y in range(10):
    listaedad.append(y)
print("*****************************")
for x in listaedad:
    print(x)



#pedro tiene 12 años
#manuel tiene 30 años
#jesus tiene 25 años
