from Vehiculo import Vehiculo
class Bicicleta(Vehiculo):
    def __init__(self,color,ruedas,tipo):
        Vehiculo.__init__(self,color,ruedas)
        self.tipo=tipo
    def imprimir(self):
        return Vehiculo.imprimir(self) + " tipo " + str(self.tipo)
#crear clases que tengan padre eh hijos
#el padre sera animal
#los hijos perro y gato
#los atributos ustedes los disenian
#los metodos ustedes los disenian
#pero ambos hijos tienen el metodo imprimir informacion
