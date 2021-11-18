def hanoi(n, pilar_inicial, pilar_final, pilar_auxiliar):
    if n == 1:
        print(pilar_inicial + "-->" + pilar_final)#Caso base o caso numero 1
    else:
        hanoi(n - 1, pilar_inicial, pilar_auxiliar, pilar_final)
        print(pilar_inicial + "-->" + pilar_final)
        hanoi(n - 1,pilar_auxiliar,pilar_final,pilar_inicial)
hanoi(3,"Pilar 1","Pilar 3", "Pilar 2")
