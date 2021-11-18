#crear 3 clases diferentes por cada alumno
#cada clase debe tener como minimo 3 metodos
#crear un archivo que llame a esas clases y cree 2 objetos por cada uno
#ejecutar todos los metodos por cada objeto creado
class cantante:
    def __init__(self,nombre,edad,genero,genmusica):
        self.nombre=nombre
        self.edad=edad
        self.genero=genero
        self.genmusica=genmusica

    def cantar(self):
        print(self.nombre," canta")
    def caminar(self):
        print(self.nombre," camina en el escenario")
    def saludar(self):
        print(self.nombre," saluda a sus fans")

class vehiculo:
    def __init__(self,marca,modelo,tipo,tipodemotor,transmision,color):
        self.marca=marca
        self.modelo=modelo
        self.tipo=tipo
        self.tipodemotor=tipodemotor
        self.transmision=transmision
        self.color=color
    def arrancar(self):
        print(self.modelo," arranca correctamente")
    def avanzar(self):
        print(self.modelo," avanza correctamente")
    def frenar(self):
        print(self.modelo," frena correctamente")

class teclado:
    def __init__(self,marca,cteclas,idioma,tipodeteclado):
        self.marca=marca
        self.cteclas=cteclas
        self.idioma=idioma
        self.tipodeteclado=tipodeteclado
    def conectar(self):
        print("El teclado de ", self.marca, " se conecto correctamente")
    def escribe(self):
        print("El teclado de ", self.marca, " escribe correctamente")
    def desconectar(self):
        print("El teclado de ", self.marca, " Se desconecto correctamente")
