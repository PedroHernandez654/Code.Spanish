from Persona import Persona
class Empleado(Persona):
    def __init__(self,nombre,apellido,edad,puesto,salario):
        Persona.__init__(self,nombre,apellido,edad,)
        self.puesto=puesto
        self.salario=salario
    def imprimir(self):
        return Persona.imprimir(self)+", tiene el pueso de "+str(self.puesto)+" y gana "+str(self.salario)+" al mes"
    def trabajar(self):
        print(self.nombre," esta trabajando")
    def pago(self):
        print(self.nombre," esta recibiendo su salario")
    def getSalario(self):
        return self.salario
    def setSalario(self,salario):
            self.salario=salario
