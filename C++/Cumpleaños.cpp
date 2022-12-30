#include <ctime>
#include <iostream>
using namespace std;
int main(){
    time_t t = time(0);
    int anoactual = localtime(&t)->tm_year + 1900;
    int mesactual = localtime(&t)->tm_mon + 1;
    int diaactual = localtime(&t)->tm_mday;
    int diacump, mescump, anocump, edad, cump = 0;
    //introduccion de variables
    cout<< "Que dia naciste? ";
    cin>>diacump;
    cout<< "Que mes naciste?(en numeros) ";
    cin>>mescump;
    cout<< "Que anio naciste? ";
    cin>>anocump;
  //evaluacion
    if (mescump == mesactual){
        if (diacump < diaactual){
            cump = 1;
        }else if (diacump == diaactual) {
    cump = 2;
    }
    }
    if (mescump < mesactual){
        cump = 1;
    }
    //impresion de los datos
    if (cump == 1){
            cout<< "Ya has cumplido anios este anio " << endl;
            cout << "Tu tiendes la edad de  " << (anoactual - anocump) << " anios" << endl;
    }else if (cump == 0) {
    cout << "No has cumplido anios este anio" << endl;
    cout << "Tu tiendes la edad de " << (anoactual - anocump)- 1 << " anios" << endl;
    }else if (cump == 2 ){
     cout << "Hoy es tu cumpleanios, FELICIDADES!!" << endl;
     cout << "Tu tiendes la edad de  " << (anoactual - anocump) << " anios" << endl;

    }
    return 0;
}
