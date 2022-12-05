using System;
using System.Collections.Generic;

namespace Algoritmo_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninicio = 0, Nfinal = 0, Distancia = 0, CantNodos = 12, NodoActual = 0, columa = 0;
            string NodoDato;
            //nodo, relación nodo, peso
            grafos g = new grafos(CantNodos);
            g.ADDarista(1, 7, 2);
            g.ADDarista(1, 4, 13);
            g.ADDarista(4, 3, 10);
            g.ADDarista(7, 6, 17);
            g.ADDarista(7, 10, 8);
            g.ADDarista(10, 9, 8);
            g.ADDarista(6, 3, 11);
            g.ADDarista(6, 9, 9);
            g.ADDarista(3, 1, 25);
            g.ADDarista(3, 2, 2);
            g.ADDarista(3, 5, 30);
            g.ADDarista(9, 5, 15);
            g.ADDarista(5, 2, 1);
            g.ADDarista(5, 8, 14);
            g.ADDarista(8, 9, 3);
            g.ADDarista(8, 11, 6);
            g.ADDarista(11, 10, 7);

            g.ShowMatriz();
            //Pedimos los datos iniciales
            Console.WriteLine("Inserte el Nodo Inicial: ");
            Ninicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el Nodo Final: ");
            Nfinal = int.Parse(Console.ReadLine());

            //Se crea una tabla para poder guardar los datos 
            int[,] table = new int[CantNodos, 3];
            string[] datos = new string[] {"Visitado", "Distancia", "Previo"};
            //se crea la tabla 
            for (int i = 0; i < CantNodos; i++)
            {
                table[i, 0] = 0;
                table[i, 1] = int.MaxValue;
                table[i, 2] = 0;
            }
            //me cuesta "0" moverme a mi nodo inicio
            table[Ninicio, 1] = 0;

            //algoritmo
            NodoActual = Ninicio;
            do
            {   //Colocamos el nodo en el que estamos en el apartado de "Visitado"
                table[NodoActual, 0] = 1;
                //for que recorre columna por columna la matriz 
                for (columa = 0; columa < CantNodos; columa++)
                {
                    //Se busca el nodo al que está referenciado
                    if (g.ValorFC(NodoActual, columa) != 0)
                    {
                        //se calcula la "distancia", se saca el peso y se le suma al nodo actual
                        Distancia = g.ValorFC(NodoActual, columa) + table[NodoActual, 1];
                        if(Distancia < table[columa, 1])
                        {
                            //colocamos el camino "más corto"
                            table[columa, 1] = Distancia;
                            //colocamos el nodo padre
                            table[columa, 2] = NodoActual;
                        }
                    }
                }
                
                int indiceMenor = -1;
                int DisMenor = int.MaxValue;
                //buscamos la menor distancia que haya del nuevo nodo en el que estamos
                for(int j= 0; j < CantNodos; j++)
                {
                    if(table[j,1]<DisMenor && table[j, 0] == 0)
                    {
                        indiceMenor = j;
                        DisMenor = table[j, 1];
                    }
                }
                NodoActual = indiceMenor;

            } while (NodoActual != -1);
            

            //Obtenemos la ruta más corta y menos pesada
            List<int> camino = new List<int>();
            int nodo = Nfinal;
            //añadimos los nodos a la lista 
            while (nodo != Ninicio)
            {
                camino.Add(nodo);
                nodo = table[nodo, 2];
            }
            camino.Add(Ninicio);
            //sacamos el camino más corto con el método Reverse
            camino.Reverse();
            foreach(int pos in camino)
            {//imprimimos el camino más corto y de menor peso
                Console.Write("{0}-->",pos);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
