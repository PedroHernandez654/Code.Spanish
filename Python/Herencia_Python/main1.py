import Perro
import Gato
Nombre=input("Cual es el nombre del perro?: ")
pelaje=input("Que tipo de pelaje(o color) tiene el perro?: ")
genero=input("Es macho o hembra?: ")
raza=input("Que raza es el perro?: ")
anios=int(input("Cuantos anios tiene?: "))
P=Perro.Perro(pelaje,"cola",genero,Nombre,raza,anios)
print(P.imprimir())
P.jugar()
P.comer()
P.setGenero("Hembra")
print(P.getGenero())
print(P.imprimir())

print('='*120)
nombre=input("Cual es el nombre del gato?: ")
Pelaje=input("Que tipo de pelaje(o color) tiene el gato?: ")
Genero=input("Es macho o hembra?: ")
tamanio=input("De que tamanio es el gato?(Chico,Mediano o Grande): ")
anios=int(input("Cuantos anios tiene?: "))
G=Gato.Gato(Pelaje,"cola",Genero,nombre,anios,tamanio)
print(G.imprimir())
G.dormir()
G.despertar()
G.comer()
G.setGenero("Macho")
print(G.getGenero())
print(G.imprimir())
