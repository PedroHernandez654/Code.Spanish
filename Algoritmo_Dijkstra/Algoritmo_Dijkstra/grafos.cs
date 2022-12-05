using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo_Dijkstra
{
    class grafos
    {
        int[,] matriz; //matriz para visualizar 
        int[] grado; // guarda el grado de los nodos
        int nodos; // cantidad de nodos que hay en el grafo
        //contructor
        public grafos(int Nnodos)//recibe la cantidad de nodos para el grafo 
        {
            nodos = Nnodos;
            //se crea la matriz
            matriz = new int[nodos, nodos];

            //se crea el arreglo donde se almacenan los grados
            grado = new int[nodos];
        }
        //se crea una funación de añadir la arista, sin embargo como tenemos un grafo dirigido
        //se le dan los parámetros de inicio y final
        //Esto es la información del peso 
        public void ADDarista(int NodoInicial, int NodoFinal, int PesoNodo)
        {
            matriz[NodoInicial, NodoFinal] = PesoNodo;
        }
        
        public void ShowMatriz()
        {
            //se le da un color distinto para visualizar mejor la matriz
            Console.ForegroundColor = ConsoleColor.Green;
            //for para nada más visualizar la matriz 
            for(int i = 0; i < nodos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
            //for que muestra los datos de la matriz
            for (int i = 0; i < nodos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i);
                for(int j = 0; j < nodos; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t{0}", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        //Esto es para saber que nodo está conectado con otro nodo 
        public int ValorFC(int Fila, int Columna)
        {
            return matriz[Fila, Columna];
        }
        //Practicamente deslinda la conexión con otro grado que ya se "sacó" 
        public void DecrementGrados(int Nodo)
        {
            grado[Nodo] = -1;

            for(int i = 0; i < nodos; i++)
            {
                if (matriz[Nodo, i] == 1)
                {
                    grado[i]--;
                }
            }
        }

    }
}
