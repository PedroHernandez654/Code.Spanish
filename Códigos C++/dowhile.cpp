#include <iostream>
using namespace std;
int main ()
{
    float cal=0, sum=0, prom=0;
    int cont=0;
    do {
        cout << "Ingrese la califiacion:" << endl;
        cin >> cal;
        if(cal!=-1) {
            sum += cal;
            cont++;
        }
    }while (cal!=-1);
    if (cont>0) {
        prom = sum/cont;
    cout << "promedio: " << prom;
    }
    else{
        cout << "Numero de califiacion invalido" <<endl;
    }
    return 0;
}

