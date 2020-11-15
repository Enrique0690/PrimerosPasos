using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a, b, suma; ; //declarar una variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de  {0} + {1} = {2}", a, b, suma);
            Console.ReadKey();
            //tipo de dato: flotante 
            float sueldo, egreso, total;
            Console.WriteLine("Ingresa el sueldo de trabajador: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el sueldo de trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;
            Console.WriteLine("El liquido a recibir es: {0} ", total);



            //tipo de dato: flotante de doble presicion
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato double: {0}", x1);

            //tipo de dato: caracteres(string)
            String nombre;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", Bienvenidos al curso de Programacion");

            //tipo de dato boleano(tipo logico: verdadero/falso) (true/flase)
            bool sw;

            sw = (a + 50) > b;

            Console.WriteLine("El valor del booleano sw: {0}", sw);

            //Pilares fundamentales de la programacion estructuradas
            //ejecucion  de sentencias secuenciales
            //uso de estructuras repetitivas
            //uso de estructuras selectivas
            saludos(nombre);
            saludos("Jose Alcivar");
            saludos("Josue Nazareno");
            saludos("Maria Alcivar");

            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuelve valor");
            Console.WriteLine("Liquido a recibir para Juan{0}", calcularSueldo(300, 200));
            Console.WriteLine("Liquido a recibir para Carlos{0}", calcularSueldo(300, 200));
            Console.WriteLine("Liquido a recibir para Lesli{0}", calcularSueldo(300, 200));

            figura();
            cuadrado();
            condicion();
            repeticion();

            Console.ReadKey();
        }//fin del main
         //funciones: subprocesos - subprogramas - subrutinas
         //dividir el codigo en modulos 
         //reutilizar el codigo
         //tipo: devuelven valores - no devuelve valores

        static void saludos(string nombre) //parametro - 
        {

            Console.WriteLine("Funcion que no devuelve valores...");
            Console.WriteLine("Hola {0}", nombre);
        }
        //funcion que devuelve valor
        //la funcion devuelve un tipo de dato

        static int calcularSueldo(int ingreso, int egreso)
        {

            return (ingreso - egreso);
        }
        //crear la funcion que imprima la siguiente figura
        //    *
        //   *
        //  ***
        // ***
        static void figura()
        {
            Console.WriteLine("   *  ");
            Console.WriteLine("  *** ");
            Console.WriteLine(" ***** ");
            Console.WriteLine("******* ");

        }
        static void cuadrado()
        {
            int valor;
            Console.WriteLine("Escrbia un numero : ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado de {0} es {1}", valor, valor*valor);
        }
        static void condicion()
        {
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 0)
            {
                if (edad > 17)
                    Console.WriteLine("Usted es mayor de edad");
                else
                    Console.WriteLine("Usted es menor de edad");
            }
            else
                Console.WriteLine("Edad no valida");
        }
        static void repeticion()
        {
            int boleto;
            Console.WriteLine("Ingrese el numero de boletos que desea : ");
            boleto = int.Parse(Console.ReadLine());
            for (int i = 1; i <= boleto; i++)
            {
                Console.WriteLine("Boleto Numero {0}",i);
            }
            Console.WriteLine("Gracias por elegirnos vuelva pronto :D");
        }
    }
}