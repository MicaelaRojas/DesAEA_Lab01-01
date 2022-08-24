using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int y, int d)
        {
            return y - d;
        }
        static int Multi(int x, int g)
        {
            return x * g;
        }
        static int Divi(int h, int i)
        {
            return h / i;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        //Procedimientos necesarios para que la aplicación pueda imprimir los 10 primeros números primos.
        static void Primos()
        {
            int num = 2, div = 0;
            while(num <= 30)
            {
                for(int i=1; i<= num; i++)
                {
                    if (num%i==0)
                    {
                        div++;
                    }
                    if (div>2)
                    {
                        break;
                    }
                }
                if (div == 2)
                {
                    Console.WriteLine("{0} es un numero primo", num);
                }
                div = 0;
                num++;
            }
        }
        static int CaF(int num)
        {
            return ((9 * num) / 5) + 32;
          
        }
        static int FaC(int num2)
        {
            return (5 * (num2 - 32)) / 9;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta  de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Conversión de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    //Operaciones basicas
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.WriteLine("La multiplicaciín de {0} y {1} es {2}", a, b, Multi(a, b));
                        Console.WriteLine("La divición de {0} y {1} es {2}", a, b, Divi(a, b));

                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", x, d, Resta(x, d));

                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicaciín de {0} y {1} es {2}", y, g, Multi(y, g));

                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La divición de {0} y {1} es {2}", h, i, Divi(h, i));

                        Console.ReadKey();
                        break;


                    //Calcular la raiz
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;


                    //Calcular numeros primos
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;

                    //Conversion de Temperatura
                    case "7":
                        Console.WriteLine("Ingrese C si el grado que quiere transformar es Celcius");
                        Console.WriteLine("Ingrese F si el grado que quiere transformar es Fahrenheit");
                        string opcion2;
                        opcion2 = Console.ReadLine();
                        switch (opcion2)

                        {
                            case "C":
                                Console.WriteLine("Ingrese el grado celsius a transformar");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El grado celsius {0} transformado a fahrenheit es {1}", num, CaF(num)); 
                                Console.ReadKey();
                                break;
                            case "F":
                                Console.WriteLine("Ingrese el grado fahrenheit a transformar");
                                int num2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El grado fahrenheit {0} transformado a celsius es {1}", num2, FaC(num2));
                                Console.ReadKey();
                                break;
                         
                        }

                        break;
                }
            } while (!opcion.Equals("0"));

        }

    }
}
