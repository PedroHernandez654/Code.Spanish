from Persona import Persona
class Visitante(Persona):
    def __init__(self,nombre,apellido,edad,fecha):
        Persona.__init__(self,nombre,apellido,edad)
        self.fecha=fecha
    def imprimir(self):
        return Persona.imprimir(self)+" visito el resinto en la fecha "+str(self.fecha)
    def visita(self):
        print(self.nombre," visita el resinto")
    def rompe(self):
        print(self.nombre," rompe un articulo")
    def pago(self):
        print(self.nombre," paga por lo que se rompio")
    def getFecha(self):
        return self.fecha
    def setFecha(self,fecha):
        self.fecha=fecha
