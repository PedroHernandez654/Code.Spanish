#include<iostream>
using namespace std;
int main ()
{
    int cuadro[4][4];
    int c=1;
    for (int j=0;j<4;j++){
        for (int i=0;i<4;i++){
            if(c==16){
                c=0;
            }
            cuadro[i][j]=c;
            c++;
        }
    }
    for (int i=0;i<4;i++){
        for (int j=0;j<4;j++){
            cout<<cuadro[i][j]<<"\t";
        }
        cout << endl;
    }
    return 0;
}
