#include <iostream>
using namespace std;

int main ()
{
    int num, multi=1;
    cout << "Ingrese un numero" << endl;
    cin >> num;
    do{
        multi *= num;
        cout << "ingrese un numero" << endl;
        cin >> num;


    }while (num!=0);


    cout << "El total es de: " << multi;

}
