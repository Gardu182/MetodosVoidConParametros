///Importación de bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MenuGenerico
{
    //Clase principal
    class Program
    {
        //Método main
        static void Main(string[] args)
        {             
            bool salir = false; //Variable que nos permite saber si el usuario quiere salir o no
            while (!salir) { //Mientras el usuario no quiera salir se repite:
                try //Envolvemos el código que puede generar error en un bloque try-catch, el error puede ser que no nos de un número como opción
                {                     
                    //Opciones del menú
                    Console.WriteLine("1. Ordenar Palabras");
                    Console.WriteLine("2. Calculadora");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    //Convertimos a entero la opción introducida por el usuario, si ocurre un error al convertir se va a l bloque catch
                    int opcion = Convert.ToInt32(Console.ReadLine());
    
                    //Estructura de control que nos permite ir a una porción u otra de código
                    //Opcion es la variable de control si coincide con una opcion entra a ese bloque de código
                    switch (opcion)
                    {
                        case 1://Si coincide con 1
                            Console.WriteLine("Introduce la primera palabra");
                            string palabra1 = Console.ReadLine(); 
                            Console.WriteLine("Introduce la segunda palabra");
                            string palabra2 = Console.ReadLine(); 
                            Console.WriteLine("Introduce la tercera palabra");
                            string palabra3 = Console.ReadLine();
                            listaPalabras(palabra1, palabra2, palabra3); 
                            break;//Salimos del bloque
 
                        case 2://Si coincide con 2
                            Console.WriteLine("Introduce el primer numero");
                            int numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el segundo numero");
                            int numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el tercer numero");
                            int numero3 = Convert.ToInt32(Console.ReadLine());
                            calculadoraNumeros(numero1, numero2, numero3);
                            break;

                        case 3:
                            Console.WriteLine("Hasta luego");
                            salir = true;
                            break;
                        default://Si no coincide con las opciones de 1 a 4 se ejecuta esto siempre que sea un número
                            Console.WriteLine("Opción no válida, elige una opcion entre 1 y 4");
                            break;
                    } 
                }
                catch (FormatException e)//Capturamos la excepción que pueda ocurrir
                {
                    Console.WriteLine("Formato incorrecto " + e.Message);//Mostramos el mensaje de la excepcioón
                }
            }
 
            Console.ReadLine();//Leemos un caracter para que haga una pausa antes de salir
 
        }

        public static void listaPalabras(string palabraUno, string palabraDos, string palabraTres)
        {

            string[] palabras = new string[] {palabraUno, palabraDos, palabraTres};

            string temp;
            for(int n = 0; n < palabras.Length - 1; n++)
            {

                for(int m = 1; m < palabras.Length - n; m++) 
                {

                    if(palabras[m].CompareTo(palabras[m-1]) > 0)
                    {
                        temp = palabras[m];
                        palabras[m] = palabras[m-1];
                        palabras[m-1] = temp;
                    }

                }

            }


            for(int i = 0; i < palabras.Length; i++)
            {

                Console.WriteLine(i + 1 + " - " + palabras[i]);
            }

            Console.WriteLine();

        }



        public static void calculadoraNumeros(int numero1, int numero2, int numero3)
        {

            double suma = numero1 + numero2 + numero3;
            double resta = numero1 - numero2 - numero3;
            double multiplicacion = numero1 * numero2 * numero3;

            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Resta = " + resta);
            Console.WriteLine("Multiplicacion = " + multiplicacion);

        }

    }

}

