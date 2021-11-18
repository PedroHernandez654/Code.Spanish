#include <iostream>
using namespace std;
int main (){
    int numero, par, a=1, factorial=0;
    do{
        cout << "Ingrese un numero positivo:" << endl;
        cin >> numero;
        if (numero<=0){
            cout<< "\tNumero no valido"<< endl;
        }
    }while (numero<=0);
    bool primo = true;
    if (numero == 0 || numero == 1 || numero == 4){
        primo = false;
    }
    for (int i=2;i<numero/2;i++){
        if (numero %i == 0){
            primo = false;
        }
    }
    if (primo == true){
        cout<<"Es primo" << endl;
    }
    if (primo == false){
        cout<<"No es primo" << endl;
    }
    if (numero%2==0){
    cout << "El numero es Par" <<endl;
    }else{
    cout << "El numero es Impar" << endl;
}
    for (int x=1;x<=numero;x++)
    {
        factorial = factorial+x;
    }
    cout << factorial;
return 0;
}

