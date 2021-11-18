#include <iostream>
using namespace std;
int main ()
{
    float cal = 0, sum = 0, prom = 0;
    int cont=0;
    cout << "Ingresa la calificacion" << endl;
    cin >> cal;
    while (cal!=-1){
        sum += cal; //sum = sum + cal
        cont++;
        cout << "ingresa la calificacion" << endl;
        cin >> cal;
    }
    if (cont>0)
    {
        prom = sum/cont;
        cout << "Promedio: " << prom << endl;
    }
    else {
        cout << "Numero de califiacion invalido";
    }

    return 0;
}
