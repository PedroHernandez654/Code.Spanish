//programado por Pedro Hernandez
#include<iostream>
using namespace std;
float cal=0, suma=0, prom=0, reprobados=0, maxi=0, mini=100;
int cont=0;
void maximo(){
    if (cal>=maxi){
            maxi = cal;
}
}
float promedio(){
    prom = suma/2;
}
void reprobado(){
    if (prom<=59){
        reprobados++;
    }
}
int main()
{
    do{
    cout << "Ingrese una calificacion:"<< endl;
        cin >> cal;
        if (cal>-1 && cal<101){
            suma += cal;
            cont++;
            maximo();
            promedio();
            reprobado();
        }
        else{
            cout << "Numero invalido" << endl;
        }

    }while(cont!=2);
    cout << "La calificacion mayor fue de: "<< maxi <<endl;
    cout << "Su promedio es de: "<<prom<<endl;
   if(reprobados==2){
     cout<<"Reprobado";
   }else{
       cout<<"Aprobado";
   }
    return 0;
}
