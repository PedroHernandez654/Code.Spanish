class Vehiculo():
    def __init__(self,color,rueda):
        self.color=color
        self.rueda=rueda

    def imprimir(self):
        return "El vehiculo es de color "+str(self.color)+" ,tiene "+str(self.rueda) + " ruedas "
