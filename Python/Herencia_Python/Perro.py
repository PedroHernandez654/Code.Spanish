from Animal import Animal
class Perro(Animal):
    def __init__(self,pelaje,cola,genero,nombre,raza,anio):
        Animal.__init__(self,pelaje,cola,genero)
        self.nombre=nombre
        self.raza=raza
        self.anio=anio
    def imprimir(self):
        return Animal.imprimir(self)+", "+str(self.nombre)+" es de raza "+str(self.raza)+" y tiene "+str(self.anio)+" anios"
    def jugar(self):
        print(self.nombre," esta jugando")
    def comer(self):
        print(self.nombre," esta comiendo")
    
