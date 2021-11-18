class Persona():
    def __init__(self,nombre,apellido,edad):
        self.nombre=nombre
        self.apellido=apellido
        self.edad=edad
    def imprimir(self):
        return "La persona " + str(self.nombre) + " " + str(self.apellido) + " tiene una edad de " + str(self.edad)
    def getNombre(self):
        return self.nombre
    def setNombre(self,nombre):
        self.nombre=nombre
    def getApellido(self):
        return self.apellido
    def setApellido(self,apellido):
        self.apellido=apellido
    def getEdad(self):
        return self.edad
    def setEdad(self,edad):
        self.edad=edad
    
