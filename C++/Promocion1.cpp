#include <ctime>
#include <iostream>
using namespace std;
using namespace std;
int main(){
int a, b, c, promo;
cout << "Ofrecemos el 3 x 2 en nuestro servicio" << endl;
cout << "Ponga el precio del 1er producto: ";
cin>> a;
cout << "Ponga el precio del 2do producto: ";
cin>> b;
cout << "Ponga el precio del 3er producto: ";
cin>> c;
if (a > b && b > c){
    promo = (a + b);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (a > c && c > b){
    promo = (a + c);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (b > a && c > b){
    promo = (b + c);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (b > c && c > a) {
    promo = (b + c);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (a == b && a > c){
    promo = (a + c);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (a == b && a < c){
    promo = (a + c);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (a == c && a < b){
    promo = (a + b);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (b == c && b < a){
    promo = (c + a);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}else if (a == b && b == c){
   promo = (a + b);
    cout << "El costo a pagar con promocion es de: " << promo << endl;
}
return 0;
}
