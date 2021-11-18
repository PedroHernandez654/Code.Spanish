class Perro:
    def __init__(self,color,raza,altura,peso,edad,genero,nombre):
        self.color = color
        self.raza =  raza
        self.altura = altura
        self.peso = peso
        self.edad = edad
        self.genero = genero
        self.nombre = nombre


    def ladrar(self):
        print("El perro ",self.nombre, " ladra")
    def dormir(self):
        print("El perro ",self.nombre, " Duerme")
