#ciclo while
var1 = int(input("inserte primer numero: "))
var2 = int(input("inserte segundo numero: "))
selec = 0
while selec != 5:
    selec = int(input("1.- sumar \n 2.- Restar \n 3.-Multiplicar \n 4.-Dividir \n 5.-Cerrar \n"))
    if selec == 1:
        print("resultado: "+ str(var1 + var2))
    if selec == 2:
        print(var1 - var2)
        print("resultado: "+ str(var1 - var2))
    if selec == 3:
        print(var1 * var2)
        print("resultado: "+ str(var1 * var2))
    if selec == 4:
        if var2 == 0:
            print("No se puede dividir entre 0")
            var2 = int(input("Inserte de nuevo el numero: "))
        else:
            print(var1 / var2)
            print("resultado: "+ str(var1 / var2))
