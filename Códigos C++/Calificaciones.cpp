#include <iostream>
using namespace std;
int main ()
{
    float cal=0, suma=0, prom=0, reprobados=0, maxi=0, mini=100;
    int cont=0;
    do{
        cout << "Ingrese una calificacion:"<< endl;
        cin >> cal;
        if (cal>-1 && cal<101){
            suma += cal;
            cont++;
            if (cal<=59){
                reprobados++;
            }
            if (cal>=maxi){
                maxi = cal;

            }
            if (mini>=cal){
                mini = cal;
            }
        }
        else{
            cout << "Numero invalido" << endl;
        }

    }while(cont!=5);
    prom = suma/5;
    cout << "Su promedio es de: " << prom << endl;
    cout << "El numero de reprobados es: " << reprobados << endl;
    cout << "Su calificacion Maxima es de: " << maxi << endl;
    cout << "Su calificacion Minima es de: " << mini << endl;
    return 0;
}


