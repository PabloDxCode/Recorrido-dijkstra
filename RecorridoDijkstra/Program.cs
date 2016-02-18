using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorridoDijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, contador = 0;
            int nodo1,nodo2;
            int[,] matriz = null;
            int peso = 0, bandera = 0;
            int nodoTemp = 100;

            AlgoritmoDijkstra dijkstra = new AlgoritmoDijkstra();

            do
            {

                Console.WriteLine("\nSelecciona la opcion:\n1.-Nuevo grafo.\n2.-Aplicar algoritmo dijkstra.\n3.-Encontrar recorrido minimo.\n4.-Salir.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        matriz = dijkstra.setGrafo(matriz);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Inserta el nodo inicial(Coloca la letra mayuscula): ");
                        nodo1 = Convert.ToChar(Console.ReadLine());
                        nodo1 = nodo1 - 65;

                        dijkstra.setNodoInicio(nodo1);
                        dijkstra.algoritmoDijkstra(matriz, nodo1, peso, bandera, nodoTemp);
                        //Console.ReadKey();
                        Console.Clear();
                        nodo1 = 0;
                        peso = 0;
                        bandera = 0;
                        break;
                    case 3:
                        Console.Write("Inserta el nodo al que deseas llegar(Coloca la letra mayuscula): ");
                        nodo2 = Convert.ToChar(Console.ReadLine());
                        nodo2 = nodo2 - 65;

                        dijkstra.recorridoMinimo(nodo2);
                        //dijkstra.imprimirResultado();
                        contador = 0;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        dijkstra.imprimir();

                        break;
                }

            } while (op != 4);
        }
    }
}
