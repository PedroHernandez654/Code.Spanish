#include <iostream>
using namespace std;
int main ()
{
    int clave = 0, intentos=0;// declaramos variables para ingreso
    do {
        cout << "Ingresa tu clave de acceso:" << endl;
        cin >> clave;//leemos la clave
        intentos++;
        if (clave !=1234){// intentos
            cout << "clave incorrecta" << endl;
        }
    }while (clave!=1234 && intentos<3);
    if (clave==1234 ){
            cout << "Bienvenido!!!" << endl;
            cout << "******************************************************************************************************";
    }
    else {
        cout << "Has superado el numero de intentos" << endl;
    }



}
