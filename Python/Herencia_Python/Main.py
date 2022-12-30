import Coche
import bicicleta
color=input("De que color es el auto? ")
c= Coche.Coche(color,4,150,"V4")
print(c.imprimir())
tipo=input("Que tipo es la bicicleta?(Urbana, Deportiva)")
b=bicicleta.Bicicleta("azul",2,tipo)
print(b.imprimir())
