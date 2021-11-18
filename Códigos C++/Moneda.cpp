#include <iostream>
using namespace std;
int main(){
int moneda;
cout << "Ingrese el valor de la moneda: ";
cin >> moneda;
switch (moneda)
{
case 1:
    cout << "La moneda es valida";
    break;
case 2:
    cout << "La moneda es valida";
    break;
case 5:
    cout << "La moneda es valida";
    break;
case 10:
    cout << "La moneda es valida";
    break;
default:
    cout << "La moneda no es valida";
    break;
}
return 0;
}

