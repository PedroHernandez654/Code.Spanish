#include <iostream>
#include <time.h>
#include <string.h>
using namespace std;
int main()
{
    float calif[5][6], proma[5]={0}, promm[6]={0},prom,suma=0,mayor=0;
    string  nombres[]={"Nadiux","Pedro","Rodrigo","Valentina","Eli"};
    int x=0;
    srand(time(0));
    for(int i=0;i<5;i++){
        for(int j=0;j<6;j++){
            calif[i][j]=rand()%10+1;
            suma+=calif[i][j];
        }
        proma[i]=suma/6;
        suma=0;
    }
    //buscando el mayor promedio
    for(int i=0;i<5;i++){
        if(proma[i]>mayor){
            mayor=proma[i];
            x=i;
        }
    }

    for(int i=0;i<5;i++){
        for(int j=0;j<6;j++){
            cout<<calif[i][j]<<"\t";
        }
        cout<<endl;
    }
    for(int i=0;i<5;i++){
        for(int j=0;j<6;j++){
            suma +=calif[i][j];
        }
        promm[i]=suma/5;
        suma=0;
    }
    cout <<"Promedios por alumnos:"<<endl;
    for(int i=0;i<5;i++){
        cout << nombres[i]<<"\t"<<": " <<proma[i]<<endl;
    }
    cout <<"Promedios por asignatura:"<<endl;
    for(int i=0;i<6;i++){
        cout << "Materia "<< i+1 <<": "<<promm[i]<<endl;
    }
    cout<<endl;
    cout << "El mejor promedio es de " <<nombres[x]<<" con "<<mayor;
    }
