import clases
nombre=input("Cual es el nombre de su cantante numero 1?: ")
edad=int(input("Cual es la edad?: "))
genero=input("Genero(Hombre,Mujer,otro): ")
genmusica=input("Que genero de musica canta?: ")
c1=clases.cantante(nombre,edad,genero,genmusica)
c1.cantar()
c1.caminar()
c1.saludar()
nombre=input("Cual es el nombre de su cantante numero 2?: ")
edad=int(input("Cual es la edad?: "))
genero=input("Genero(Hombre,Mujer,otro): ")
genmusica=input("Que genero de musica canta?: ")
c2=clases.cantante(nombre,edad,genero,genmusica)
c2.cantar()
c2.caminar()
c2.saludar()

marca=input("Que marca es el vehiculo?: ")
modelo=input("Cual es su modelo?: ")
tipo=input("Tipo(Sedan,Coupe,SUV,Camioneta,Vans,Motocicleta,etc): ")
tipodemotor=input("Que tipo de motor es?(V4,V6,V8,etc): ")
transmision=input("Tipo de transmision(Manual,Automatico): ")
color=input("De que color es el vehiculo?: ")
a1=clases.vehiculo(marca,modelo,tipo,tipodemotor,transmision,color)
a1.arrancar()
a1.avanzar()
a1.frenar()

marca=input("Que marca es el vehiculo numero 2?: ")
modelo=input("Cual es su modelo?: ")
tipo=input("Tipo(Sedan,Coupe,SUV,Camioneta,Vans,Motocicleta,etc): ")
tipodemotor=input("Que tipo de motor es?(V4,V6,V8,etc): ")
transmision=input("Tipo de transmision(Manual,Automatico): ")
color=input("De que color es el vehiculo?: ")
a2=clases.vehiculo(marca,modelo,tipo,tipodemotor,transmision,color)
a2.arrancar()
a2.avanzar()
a2.frenar()

marca=input("Que marca es el teclado?: ")
cteclas=int(input("Cuantas teclas tiene el teclado?: "))
idioma=input("En que idioma esta el teclado?: ")
tipodeteclado=input("Tipo de teclado(Membrana,Mecanico,Memcanico): ")
t1=clases.teclado(marca,cteclas,idioma,tipodeteclado)
t1.conectar()
t1.escribe()
t1.desconectar()

marca=input("Que marca es el teclado numero 2?: ")
cteclas=int(input("Cuantas teclas tiene el teclado?: "))
idioma=input("En que idioma esta el teclado?: ")
tipodeteclado=input("Tipo de teclado(Membrana,Mecanico,Memcanico): ")
t2=clases.teclado(marca,cteclas,idioma,tipodeteclado)
t2.conectar()
t2.escribe()
t2.desconectar()