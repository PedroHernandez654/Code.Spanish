from Animal import Animal
class Gato(Animal):
    def __init__(self,pelaje,cola,genero,nombre,anio,tamanio):
        Animal.__init__(self,pelaje,cola,genero)
        self.nombre=nombre
        self.tamanio=tamanio
        self.anio=anio
    def imprimir(self):
        return Animal.imprimir(self)+", "+str(self.nombre)+" tiene un tamanio  "+str(self.tamanio)+" y tiene "+str(self.anio)+" anios"
    def dormir(self):
        print(self.nombre," duerme")
    def despertar(self):
        print(self.nombre," se despierta")
    def comer(self):
        print(self.nombre," esta comiendo")
