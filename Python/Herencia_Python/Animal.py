class Animal():
    def __init__(self,pelaje,cola,genero):
        self.pelaje=pelaje
        self.cola=cola
        self.genero=genero
    def imprimir(self):
        return "El animal tiene pelaje "+str(self.pelaje)+" es "+str(self.genero)+" y tiene "+str(self.cola)
    def getPelaje(self):
        return self.pelaje
    def setPelaje(self,pelaje):
        self.pelaje=pelaje
    def getCola(self):
        return self.cola
    def setCola(self,cola):
        self.cola=cola
    def getGenero(self):
        return self.genero
    def setGenero(self,genero):
        self.genero=genero
