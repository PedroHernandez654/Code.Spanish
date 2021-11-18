#diccionario {}
dic={"uno":1,"dos":2,"altura":1.70} #llave, el valor
dic["nombre"] = "Pedro" #Esto agrega al diccionario
dic2 = dict(nombre = "Pedro", altura = 1.70, edad = 26)
print(type(dic))
print(dic["dos"])
print(dic2)
#las tuplas no pueden cambiar en el diccionario si
print(dic.keys())
#solo se imprimen solo las palabras clave
print(dic.values())
#solo se imprimen los valores
