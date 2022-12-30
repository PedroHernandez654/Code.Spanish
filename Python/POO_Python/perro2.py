import perro

dog = perro.Perro("Blanco","pst Aleman",1,35,4,"Macho","Firulais")
dog.ladrar()
dog.dormir()
nombre = input("Dame el Nombre del segundo Perro: ")
dog2 = perro.Perro("Negro","French",.5,10,2,"Macho",nombre)
dog2.ladrar()
dog2.dormir()
