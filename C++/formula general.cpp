//formula general
#include <iostream>
#include <cmath>
using namespace std;
int main(){
    float a, b, c, disc, x1, x2;
    cout<< "Se resolvera una ecuacion cuadratica ax^2 + bx + c = 0"<<endl;
    cout<< "Ingrese el valor de a: ";cin>> a;
    cout<< "Ingrese el valor de b: ";cin>> b;
    cout<< "Ingrese el valor de c: ";cin>> c;
    disc = (b*b) - (4 *(a * c));
    if(disc < 0){
        cout<< "La ecuacion no tiene solucion en los reales"<<endl;
        return 0;
    }else if(disc == 0){
        cout<< "El discriminante de la ecuacion es igual a 0 por lo que solo tiene un resultado"<<endl;
        x1 = (-(b) + sqrt(disc))/2;
        cout<< "x = " << x1 <<endl;
    }else if(a == 0){
        cout<< "La ecuacion no es una ecuacion cuadratica"<<endl;
        cout<< "Pero la solucion para x es "<< (-(c)/b)<<endl;
    }else{
        x1 = (-(b) + sqrt(disc))/2;
        cout<< "X1 = " << x1 <<endl;
        x2 = (-(b) - sqrt(disc))/2;
        cout<< "X2 = " << x2 << endl;
    }
    return 0;
}
