#tema los metodos get y set
class empleado:
    def __init__(self,nombre,apellido,edad,puesto):#existen para cada atributo de la clase
        self.nombre=nombre
        self.apellido=apellido
        self.edad=edad
        self.puesto=puesto
#los metodos get son para tomar el valor del atributo
    def get_nombre(self):#get sirve para aignar un valor
        return self.nombre
#los metodos set son para insertar un valor al atributo
    def set_nombre(self,nombre):
        self.nombre=nombre

    def get_apellido(self):
        return self.apellido
    def set_apellido(self,apellido):
        self.apellido=apellido
    def get_edad(self):
        return self.apellido
    def set_edad(self,edad):
        self.edad=edad
    def get_puesto(self):
        return self.puesto
    def set_puesto(self,puesto):
        self.puesto=puesto
