#include <iostream>
using namespace std;
int main ()
{
    int numero, num, a=1, sp=0, mi=1, primos=0, divisores=1;
    do{
    cout << "cuantos numeros son?" << endl;
    cin >> numero;
    for(int x=1; x<=numero;x++){
        cout << "Ingresa un numero: ";
        cin >>num;
        if (num>0){
            sp+= num;
        }
        if (num %2 == 1){
            mi *= num;
        }
        divisores =0;
        for(int y=1; y<=num;y++){
            if (num%y==0){
                divisores++;
            }
        }
        if (divisores==2){
            primos++;
        }
    }
    }while(numero<=0);
    cout << "suma de positivos: "<< sp<< endl;
    cout << "Multiplicacion de impares: " << mi<<endl;
    cout << "contar impares: " << primos;

}
