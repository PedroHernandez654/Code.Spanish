//Programado por Pedro Hernández Dzul
#include <iostream>
using namespace std;
int pago;
char combustible;
float precio, litros, pesos, total;
void operacion (){
    switch(pago){
    case 1:
        cout<< "Cuantos litros desea comprar?\n";
        cin>>litros;
        total = litros * precio;
        cout<< "\nEl total a pagar es de: "<<total<< " pesos";
        break;
    case 2:
        cout<< "Cuantos pesos desea cargar?\n";
        cin>>pesos;
        total = pesos / precio;
        cout<< "\nEl total se cargaran: "<<total<< " litros de gasolina";
        break;
    default:
        cout<< "\nNo ha ingresado una forma de pago valida";
        break;
}
}
int main(){
    cout << "Que combustible desea?" << endl;
    cout << "- Magna (M) a $19.50 \n- Premium (P) a $19.90 \n- Diesel(D) a $21.50\n";
    cin >> combustible;
    cout << "Que metodo de pago desea emplear?\n" << endl;
    cout << "1-Litros \n2-Pesos \n";
    cin >> pago;
  //toupper funcion de variable en minusculas o mayusculas
    switch(toupper(combustible)){
        case 'M':
            precio = 19.50;
            operacion();
            break;
        case 'P':
            precio = 19.90;
            operacion();
            break;
        case 'D':
            precio = 21.50;
            operacion();
            break;
        default:
            cout << "Tipo de gasolina no valido";
            break;
}
}
