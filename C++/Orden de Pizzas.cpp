#include <iostream>
using namespace std;
int main(){
int cant, precio = 0, total;
char size;
cout << "cuantas pizzas quieres?" << endl;
cin >> cant;
cout << "s=Chica \nm=Mediana\nl=Grande\nf=Familiar" << endl;
cout << "Ingresa el tamaño que desee" << endl;
cin >> size;
switch (size)
{
case 's':
    precio = 80;
    total = precio * cant;
    cout << "El total es de: " << total << endl;
    break;
case 'm':
    precio = 100;
    total = precio * cant;
    cout << "El total es de: " << total << endl;
    break;
case 'l':
    precio = 120;
    total = precio * cant;
    cout << "El total es de: " << total << endl;
    break;
case 'f':
    precio = 180;
    total = precio * cant;
    cout << "El total es de: " << total << endl;
    break;

}
return 0;

}
