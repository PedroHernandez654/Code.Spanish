//Programado por Pedro Hernandez
#include<iostream>
using namespace std;
int main()
{
    int numeros[10], temp;
    for(int i=0;i<10;i++){ //For para guardar en una lista 10 numeros
    cout << "Ingrese numeros enteros:" << endl;
    cin >> numeros[i];
    system("cls");
    }
    for(int i=0;i<10;i++){
        for(int j=0;j<9;j++){
            if(numeros[j]>numeros[j+1]){
                temp=numeros[j];
                numeros[j]=numeros[j+1];
                numeros[j+1]=temp;
            }

        }

    }
    for(int i=0;i<10;i++){
        cout << numeros[i] << " | ";
    }
return 0;
}
