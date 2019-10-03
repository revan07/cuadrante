using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_plano
{
    class punto
    {
        //definimos los atributos
        private int x, y;
        //El metodo inicializar pide cargar las cordenada x e y:
        public void inicializar()
        {
            string linea;
            Console.Write("Ingrese coordenada x:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese coordenada y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }
        //El segundo método mediante un conjunto de if verificamos en que 
        // cuadrante se encuentra el punto ingresado:
        void ImprimirCuadrante()
        {
            if (x > 0 && y > 0) //x es mayor que 0, y es mayor que 0
            {
                Console.Write("Se encuentra en el primer cuadrante.");
            }
            else
            {
                if (x < 0 && y > 0)//x es menor que 0, y es mayor que 0

                { 
                    Console.Write("Se encuentra en el segundo cuadrante."); 
                }

                if (x < 0 && y < 0) //x es menor que 0, y es menor que 0

                {
                    Console.Write("Se encuentra en el tercer cuadrante.");
                }
                else
                {
                    if (x > 0 && y < 0) //x es mayor que 0, y es menor que 0

                    {
                        Console.Write("Se encuentra en el cuarto cuadrante.");
                    }

                    else
                    {
                        Console.Write("El punto no esta en un cuadrante.");


                    }
                }
            }
            Console.ReadKey();
        }
        //La Main no tiene grandes diferencias con los problemas realizados 
       // anteriormente, declaramos un objeto de la clase Punto, creamos el objeto en el main mediante el 
        //operador new y seguidamente llamamos a los métodos Inicializar e ImprimirCuadrante en ese orden.
        static void Main(string[]args)
        {
            punto punto1 = new punto();
            punto1.inicializar();
            punto1.ImprimirCuadrante();
        }
        
        
    }
 
    

}
