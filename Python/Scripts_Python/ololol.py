def sumatoria(numero):
    suma = 0
    for n in numero:
        suma += n
    return suma
def numerosMenores(n,l):
    nueva = []
    for elemento in n:
        if elemento < l:
            nueva.append(elemento)
    return nueva

def frecuencias(numeros):
    nueva = []
    for n in numeros:
        if ((n,numeros.count(n))) not in nueva:
            nueva.append((n,numeros.count(n)))
    print(nueva)
    return nueva

#1
numeros = []
n = int(input("Favor de insertar un numero, si presiona 0 termina "))
while n != 0:
    numeros.append(n) #codigo para insertar en lista
    n = int(input("Favor de insertar un numero, si presiona 0 termina "))
#2
e = int(input("Numero a eliminar"))
if e in numeros:#in me sirve para saber si el elemento esta en la lista
    numeros.remove(e)
else:
    print("No pude eliminar el numero ")
#3
print(sumatoria(numeros))

#4
limite = int(input("Inserte limite "))
for n in numerosMenores(numeros,limite):
    print(n)

#5
print("frecuencias")
for tupla in frecuencias(numeros):
    print(tupla[0], "Aparece ", tupla[1], "Veces")
