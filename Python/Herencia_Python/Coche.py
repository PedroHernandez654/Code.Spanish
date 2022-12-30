from Vehiculo import Vehiculo
class Coche(Vehiculo):
    def __init__(self,color,ruedas,velocidad,cilindrada):
        Vehiculo.__init__(self,color,ruedas)
        self.velocidad=velocidad
        self.cilindrada=cilindrada

    def imprimir(self):
        return Vehiculo.imprimir(self) +" ,va a una velocidad de " + str(self.velocidad)  +" y tiene una cilindrada " + str(self.cilindrada)
