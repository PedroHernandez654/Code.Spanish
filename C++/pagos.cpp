#include <iostream>
using namespace std;
int main ()
{
    int dinero=0, pago=0, deposito=0, cambio=0;
    cout << "Ingresa la cantidad a pagar: ";
    cin >> pago;
    do {
        cout << "Ingresa el dinero a pagar:"<<endl;
        cin >> dinero;
        if (dinero==1 || dinero==2 || dinero==5 || dinero==10 || dinero==20 || dinero==50 || dinero==100 || dinero==200 || dinero==500 )
        {
            deposito=deposito+dinero;
        }
        else {
            cout << "Moneda invalida"<<endl;
        }


    }while(deposito<pago);
    if (deposito>pago) {
        cambio = deposito - pago;
        cout << "Su cambio es: " << cambio << endl;
    }
    cout << "Gracias por su compra";
}
