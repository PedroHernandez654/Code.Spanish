import turtle

ventana = turtle.Screen()

ventana.bgcolor("black")
ventana.title("Laberinto")
ventana.setup(700, 700)

class Bloques(turtle.Turtle):
	def __init__(self):
		turtle.Turtle.__init__(self)
		self.shape("square")
		self.color("white")
		self.penup()
		self.speed(0)
#El jugador
class Jugador(turtle.Turtle):
	def __init__(self):
		turtle.Turtle.__init__(self)
		self.shape("circle")
		self.color("yellow")
		self.penup()
		self.speed(0)

niveles = []

nivelUno = [
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXPXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXX XXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX",
	"XXXXXXXXXXXXXXXXXXXXXXXX"
]

niveles = [nivelUno]

bloques = Bloques()
jugador = Jugador()
def iniciarLaberinto(nivel):
	for fila in range(len(nivel)):
		for columna in range(len(nivel[fila])):

			caracter = nivel[fila][columna]
			ejeX = -288 + (columna * 24)
			ejeY = 288 - (fila * 24)

			if caracter == "X":
				bloques.goto(ejeX, ejeY)
				bloques.stamp()

			if caracter == "P":
				jugador.goto(ejeX, ejeY)

iniciarLaberinto(niveles[0])

ventana.mainloop()
