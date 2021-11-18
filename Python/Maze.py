import turtle
#creacion de ventana
ventana = turtle.Screen()
ventana.bgcolor("red")
ventana.title("Maze Run")
ventana.setup(500, 500)

#Esto nos permite dibujar los bloques
class Bloques(turtle.Turtle):
    def __init__(self):
        turtle.Turtle.__init__(self)
        self.shape("square")
        self.color("black")
        self.penup()#Esto es para no dejar rastro
        self.speed(0)

#El jugador
class Jugador(turtle.Turtle):
	def __init__(self):
		turtle.Turtle.__init__(self)
		self.shape("circle")
		self.color("yellow")
		self.penup()#Esto es para no dejar rastro
		self.speed(0)

#Esto sera los portales
class Portal(turtle.Turtle):
	def __init__(self):
		turtle.Turtle.__init__(self)
		self.shape("circle")
		self.color("blue")
		self.penup()#Esto es para no dejar rastro
		self.speed(0)

niveles = []

Laberinto = [
"#P##### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
"####### ########",
]


niveles = [Laberinto]

bloques = Bloques()

def iniciarLaberinto(nivel):
	for fila in range(len(nivel)):#Estos fors nos hacen poder manipular cada "#"
		for columna in range(len(nivel[fila])):

			caracter = nivel[fila][columna]
			coordinate_X = -288 + (columna * 25)
			coordinate_Y = 288 - (fila * 25)

            if caracter == "P":
				jugador.goto(coordinate_X, coordinate_Y)

			if caracter == "#":
				bloques.goto(coordinate_X, coordinate_Y)
				bloques.stamp()

jugador = Jugador()
portales = Portal()
iniciarLaberinto(niveles[0])
ventana.mainloop()
