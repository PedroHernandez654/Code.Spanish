//programado por Pedro Hernandez
#include <iostream>
#include <time.h>
using namespace std;
int main()
{
    int mat[3][3]={{2,7,6},{9,5,1},{4,3,8}},control=0,a=3;
    srand(time(0));

   /* for(int x=0;x<3;x++){
        for(int y=0;y<3;y++){
        mat[x][y]=rand()%9+1;
        }
    }*/
    for(int x=0;x<3;x++){
            int suma=0;
        for(int y=0;y<3;y++){
            suma+=mat[x][y];
            switch (x){
            case 0:
                if(suma==15){
                    control++;
                }
                break;
            case 1:
                if(suma==15){
                    control++;
                }
                break;
            case 2:
                if(suma==15){
                    control++;
                }
                break;
            default:
                break;
            }
        }
    }
    for(int x=0;x<3;x++){
            int suma=0;
        for(int y=0;y<3;y++){
            suma+=mat[y][x];
            switch (x){
            case 0:
                if(suma==15){
                    control++;
                }
                break;
            case 1:
                if(suma==15){
                    control++;
                }
                break;
            case 2:
                if(suma==15){
                    control++;
                }
                break;
            default:
                break;
            }
        }
    }
    for(int x=0;x<3;x++){
            int suma=0;
            suma+=mat[x][x];
            switch (x){
            case 0:
                if(suma==15){
                    control++;
                }
                break;
            case 1:
                if(suma==15){
                    control++;
                }
                break;
            case 2:
                if(suma==15){
                    control++;
                }
                break;
            default:
                break;
            }
        }
        for(int x=0;x<3;x++){
            int suma=0;
            suma+=mat[x][x+a];
            switch (x){
            case 0:
                if(suma==15){
                    control++;
                }
                break;
            case 1:
                if(suma==15){
                    control++;
                }
                break;
            case 2:
                if(suma==15){
                    control++;
                }
                break;
            default:
                break;
            }
            a--;
        }
    for(int x=0;x<3;x++){
        for(int y=0;y<3;y++){
            cout<<mat[x][y]<<" | ";
        }
        cout << endl;
    }
    /*if(control==8){
        cout << "Es un cuadro magico";
    }else{
        cout << "No es un cuadro magico";
    }*/
    cout << control;
}
