//Programado por Pedro Hernández
#include <iostream>
using namespace std;
int vehiculo, hr, minutos, operacion;
float total, precio;
int a (){
    if (minutos > 30 && minutos < 60){
            hr += 1;
    }else if (minutos <= 30 && minutos > 0 ){
            minutos = 30;
    }else if (minutos >= 60){
        cout << "Los minutos que ingresaste se pueden expresar como horas, favor de reiniciar el progama";
        return 0;
}
    if (minutos == 30){
            total = (precio / 2) + (precio * hr);
            cout << "El precio a cobrar es: " << total << " Pesos" << endl;
        }else{
            total = hr * precio;
            cout << "El precio a cobrar es: " << total << " Pesos" << endl;
        }
}
int main(){
    cout << "1.Moto $10\n2.Auto $15\n3.Camioneta $20\n";
    cout << "Que tipo de vehiculo estaciono?\n";
    cin >> vehiculo;
    cout << "Cuantas horas estuvo estacionado el vehiculo?\n";
    cin >> hr;
    cout << "Cuantos minutos estuvo estacionado el vehiculo?\n";
    cin >> minutos;
    switch (vehiculo) {
    case 1:
        precio = 10;
        a();
        break;
    case 2:
        precio = 15;
        a();
        break;
    case 3:
        precio = 20;
        a();
        break;
    default:
        cout << "Vehiculo no identificado";
        break;
    }
    return 0 ;

}
