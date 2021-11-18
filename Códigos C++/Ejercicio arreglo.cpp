#include <iostream>
#include <string>
using namespace std;
int main ()
{
    float temp[7], suma=0, prom=0, diff[7],tm=0;
    string dias[]={"Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado"};
    int dia=0;
    for (int i=0;i<7;i++){
        cout << "Ingrese la temperatura del " << dias[i] << " : ";
        cin >> temp[i];
        suma += temp[i];
        if (i==0){
            tm=temp[i];
            dia=i;
        }
        else{
            if(temp[i]>tm){
                tm=temp[i];
                dia=i;
            }
        }
    }
    prom = suma/7;
    cout << "El promedio de temperatura es de: "<< prom << endl;
    for (int i=0;i<7;i++){
        diff[i]=temp[i] - prom;
        cout << diff[i] << " | ";
    }
    cout << endl;
    cout << "El dia con la mayor temperatura fue el dia: " << dias[dia] << " Y fue de: "<<tm<< endl;
    return 0;
}
