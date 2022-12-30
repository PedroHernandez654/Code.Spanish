#Programado por Pedro Hernández
import math
def sumatoria(numeros):
    suma = 0
    for n in numeros:
        suma += n
    return suma
def varianza(numeros):
    division = len(numeros)
    media = sumatoria(numeros)/division
    sumcu = 0
    for n in range(division):
        sumcu += ((numeros[n]-media) * (numeros[n]-media))
    var = sumcu / division
    return var
def desviacion(numeros):
    division = len(numeros)
    media = sumatoria(numeros)/division
    sumcu = 0
    for n in range(division):
        sumcu += ((numeros[n]-media) * (numeros[n]-media))
    var = sumcu / division
    math.sqrt(var)
    return math.sqrt(var)

numeros = []
n = int(input("Favor de insertar un numero, si presiona 0 termina "))
while n != 0:
    numeros.append(n)
    n = int(input("Favor de insertar un numero, si presiona 0 termina "))
print("La sumatoria es de: " + str(sumatoria(numeros)))
print("La varianza es de: " + str(varianza(numeros)))
print("La desviacion estandar es de: " + str(desviacion(numeros)))
