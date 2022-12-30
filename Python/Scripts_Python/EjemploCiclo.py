var1 = input("Ingrese su Nombre completo: ")
var2 = ""
for x in var1:
    if x == "a" or x == "e" or x == "i" or x == "o" or x== "u":
        var2 += "*"
    else:
        var2 += x
print(var2)
