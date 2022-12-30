#metodo
a = int(input("Inserte el primer numero: "))
b = int(input("Inserte el segundo numero: "))
selec = 0
def sumar():
    print("resultado: "+ str(a + b))
def restar():
    print("resultado: "+ str(a - b))
def multiplicar(a,b):
    return a * b
def dividir(a,b):
    return a / b
while selec != 5:
    selec = int(input(" 1.- sumar \n 2.- Restar \n 3.- Multiplicar \n 4.- Dividir \n 5.- Cerrar \n"))
    if selec == 1:
        sumar()
    if selec == 2:
        restar()
    if selec == 3:
        resultado = multiplicar (a,b)
        print("El resultado es: "+ str(resultado))
    if selec == 4:
        if b == 0:
            print("No se puede dividir entre 0")
            b = int(input("Inserte de nuevo el numero: "))
        else:
            resultado = dividir (a,b)
            print("El resultado es: "+ str(resultado))
