#include <iostream>
using namespace std;
int main ()
{
    int num, x, f=0, aux=1;
    cout << "Ingrese un numero para sacar su fibonacci" << endl;
    cin >> num;
    for (x=1;x<=num;x++){
        cout << f << " ";
        aux = aux + f;
        f = aux - f;
    }
return 0;
}
