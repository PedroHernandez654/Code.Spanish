//matrices
#include<iostream>
using namespace std;
int main()
{
    int matriz [3][4];//fila luego columna
    /*matriz[3][2]=5;
    matriz[3][1]=4;
    matriz[3][0]=matriz[3][2]+matriz[3][1];*/
    for (int i=0;i<4;i++){
        for (int j=0;j<3;j++){
            cout << "Escribe un numero: ";
            cin >> matriz[i][j];
            system("cls");
        }
    }
    for (int i=0;i<4;i++){
        for (int j=0;j<3;j++){
            cout << matriz[i][j]<<"|";

        }
        cout << endl;
    }
}
