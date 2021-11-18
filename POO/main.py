import empleados

empleado1=empleados.empleado("jose","lopez",23,"ing")
print('='*25)#120
print(empleado1.get_nombre())
print('='*25)
empleado1.set_nombre("Mario")
print('='*25)
print(empleado1.get_nombre())
print('='*25)

empleado2=empleados.empleado("Maria","Manzanero",28,"Lic")
print('='*25)
print("primer objeto: ",empleado1.get_nombre()," Segundo objeto: ",empleado2.get_nombre())
print('='*25)
for x in range(0,10):
    obj=empleados.empleado("jose"+str(x),"Lopez",23,"Ing")
    print(obj.get_nombre())
