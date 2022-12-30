#include<iostream>
#include<string.h>
using namespace std;
int a,b,juego=0,usado,turno=0;
string jugador1,jugador2,gato[3][3]={{"[ ]","[ ]","[ ]"},{"[ ]","[ ]","[ ]"},{"[ ]","[ ]","[ ]"}};
char ficha;
void rep(){
        if(a>2||a<0){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador1<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Esta posicion no existe en el gato, intente de nuevo"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
        if(b>2||b<0){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador1<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Esta posicion no existe en el gato, intente de nuevo"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
        if(gato[a][b]=="[X]"||gato[a][b]=="[O]"){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador1<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Ya esta ocupada la casilla, intente con otra: "<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
}
void rep2(){
     if(a>2||a<0){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador2<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Esta posicion no existe en el gato, intente de nuevo"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
        if(b>2||b<0){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador2<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Esta posicion no existe en el gato, intente de nuevo"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
    if(gato[a][b]=="[X]"||gato[a][b]=="[O]"){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador2<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout << "Ya esta ocupada la casilla, intente con otra: "<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
        }else{
            usado++;
        }
}
void ganador(){
    if(toupper(ficha) == 'X'){
        if(gato[0][0]=="[X]"&&gato[0][1]=="[X]"&&gato[0][2]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][0]=="[X]"&&gato[1][0]=="[X]"&&gato[2][0]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][1]=="[X]"&&gato[1][1]=="[X]"&&gato[2][1]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][2]=="[X]"&&gato[1][2]=="[X]"&&gato[2][2]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[1][0]=="[X]"&&gato[1][1]=="[X]"&&gato[1][2]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[2][0]=="[X]"&&gato[2][1]=="[X]"&&gato[2][2]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][0]=="[X]"&&gato[1][1]=="[X]"&&gato[2][2]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][2]=="[X]"&&gato[1][1]=="[X]"&&gato[2][0]=="[X]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador1;
            juego=1;
        }else if(gato[0][0]=="[O]"&&gato[0][1]=="[O]"&&gato[0][2]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[0][0]=="[O]"&&gato[1][0]=="[O]"&&gato[2][0]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[0][1]=="[O]"&&gato[1][1]=="[O]"&&gato[2][1]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[0][2]=="[O]"&&gato[1][2]=="[O]"&&gato[2][2]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[1][0]=="[O]"&&gato[1][1]=="[O]"&&gato[1][2]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[2][0]=="[O]"&&gato[2][1]=="[O]"&&gato[2][2]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[0][0]=="[O]"&&gato[1][1]=="[O]"&&gato[2][2]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(gato[0][2]=="[O]"&&gato[1][1]=="[O]"&&gato[2][0]=="[O]"){
            cout <<"Felicidades!!"<<endl;
            cout<<"Gano: "<<jugador2;
            juego=1;
        }else if(turno==9){
            cout<<"Ohhh :c"<<endl;
            cout << "Empate de "<<jugador1<<" vs "<<jugador2;
            juego=1;
        }
        }else if(toupper(ficha) == 'O'){
            if(gato[0][0]=="[O]"&&gato[0][1]=="[O]"&&gato[0][2]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][0]=="[O]"&&gato[1][0]=="[O]"&&gato[2][0]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][1]=="[O]"&&gato[1][1]=="[O]"&&gato[2][1]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][2]=="[O]"&&gato[1][2]=="[O]"&&gato[2][2]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[1][0]=="[O]"&&gato[1][1]=="[O]"&&gato[1][2]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[2][0]=="[O]"&&gato[2][1]=="[O]"&&gato[2][2]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][0]=="[O]"&&gato[1][1]=="[O]"&&gato[2][2]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][2]=="[O]"&&gato[1][1]=="[O]"&&gato[2][0]=="[O]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador1;
                juego=1;
            }else if(gato[0][0]=="[X]"&&gato[0][1]=="[X]"&&gato[0][2]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[0][0]=="[X]"&&gato[1][0]=="[X]"&&gato[2][0]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[0][1]=="[X]"&&gato[1][1]=="[X]"&&gato[2][1]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[0][2]=="[X]"&&gato[1][2]=="[X]"&&gato[2][2]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[1][0]=="[X]"&&gato[1][1]=="[X]"&&gato[1][2]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[2][0]=="[X]"&&gato[2][1]=="[X]"&&gato[2][2]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[0][0]=="[X]"&&gato[1][1]=="[X]"&&gato[2][2]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(gato[0][2]=="[X]"&&gato[1][1]=="[X]"&&gato[2][0]=="[X]"){
                cout <<"Felicidades!!"<<endl;
                cout<<"Gano: "<<jugador2;
                juego=1;
            }else if(turno==9){
                cout <<"Ohhh :c"<<endl;
                cout << "Empate de "<<jugador1<<" vs "<<jugador2;
                juego=1;
        }
        }
}
int main(){
    cout << "Bienvenido a el juego del GATO!!"<<endl;
    cout << "***********************************************************************************************************************"<<endl;
    cout << "(El primer jugador siempre empezara la partida con su ficha correspondiente)"<<endl;
    cout << "Ingrese el nombre del primer jugador: "<<endl;
    cin >> jugador1;
    cout << "Ingrese el nombre del segundo jugador: "<<endl;
    cin >> jugador2;
    system("cls");
    cout<<"Ingrese que ficha desea (X)o(O) "<<jugador1<< endl;
    cin >> ficha;
    system("cls");
    while(juego==0){
        if(toupper(ficha)=='X'){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador1<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout <<"Al poner la columna y fila se asignara su ficha correspondiente"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
            while (usado == 0){
                rep();
            }
            usado=0;
            gato[a][b]="[X]";
            turno++;//llamamos
            system("cls");
            ganador();
            if(juego==1){
                break;
            }
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador2<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout <<"Al poner la columna y fila se asignara su ficha correspondiente"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
            while (usado == 0){
                rep2();
            }
            usado=0;
            gato[a][b]="[O]";
            turno++;//llamamos
            system("cls");
            ganador();//Ganador
        }else if(toupper(ficha)=='O'){
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador1<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout <<"Al poner la columna y fila se asignara su ficha correspondiente"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
            while (usado == 0){
                rep();
            }
            usado=0;
            gato[a][b]="[O]";
            turno++;//llamamos
            system("cls");
            ganador();
            if(juego==1){
                break;
            }
            cout<< "A jugar!!"<<endl;
            cout<< "Turno de: "<<jugador2<<endl;
            cout<<"   |  0  |  1  |  2  |"<<endl;
            for(int x=0;x<3;x++){
                cout<<" "<<x<<" | "<<gato[x][0]<<" | "<<gato[x][1]<<" | "<<gato[x][2]<<" | "<<endl;
            }
            cout <<"Al poner la columna y fila se asignara su ficha correspondiente"<<endl;
            cout <<"Ingrese una fila: "<<endl;
            cin >> a;
            cout<<"Ingrese una columna: "<<endl;
            cin >>b;
            system("cls");
            while (usado == 0){
                rep2();
            }
            usado=0;
            gato[a][b]="[X]";
            turno++;//llamamos
            system("cls");
            ganador();//Ganador
        }else{
            cout << "Ficha no valida, intente de nuevo: "<< endl;
            cin >> ficha;
            system("cls");
        }
        }
}
