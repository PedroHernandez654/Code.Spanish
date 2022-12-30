#include <iostream>
using namespace std;
int main ()
{
    int x,factorial=1,num;
    cout << "Ingrese un numero" << endl;
    cin >> num;
    for (x=1;x<=num;x++)
    {
        factorial = factorial*x;
    }
    cout << "El factorial de: " << num << " es " << factorial <<endl;
    return 0;
}

