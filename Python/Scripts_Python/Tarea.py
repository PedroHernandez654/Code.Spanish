print("¿Cual es su nombre?")
a = input()
print("¿cual es su estatura?")
b = float(input())
print("¿cual es su edad?")
c = int(input())

if len(a) > 5:
    print("Mi edad es:" + str(c))
    print(type(c))
else:
    print("Mi estatura es: " + str(b))
    print(type(b))
