using System;

namespace HolaMundo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Se definen las instrucciones de usuario para ejecutar el programa "Calculadora".
            Console.WriteLine("---------CALCULADORA----------\n");
            Console.WriteLine("---------Elija la Operacion que desea realizar----------");
            Console.WriteLine("---------Para SUMAR Presione el numero ........1");
            Console.WriteLine("---------Para RESTAR Presione el numero .......2");
            Console.WriteLine("---------Para MULTIPLICAR Presione el numero ..3");
            Console.WriteLine("---------Para DIVIDIR Presione el numero ......4\n");
            // Se carga el valor ingresado por el usuario a una variable tipo string.
            string operacion = Console.ReadLine();
            // Se declara variable tipo entero, con el objetivo de validar formato correcto de ingreso de informacion.
            int numeroOperacionValidado = 0;
            // Se declara variable tipo string, con el objetivo de indicar al usuario la operacion aritmetica que ejecutara el programa.
            string claseOperacion = "";
            // Operacion de validacion de formato, para atrapar error de excepcion.
            try
            {
                numeroOperacionValidado = int.Parse(operacion);
            }
            catch (FormatException)

            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
            }
            // Una vez validado el formato, se carga la variable para definir la operacion aritmetica que ejecutara el programa.
            int numeroOperacion = numeroOperacionValidado;
            // Se valida la entrada de la opcion correcta.
            if (numeroOperacion == 1 || numeroOperacion == 2 || numeroOperacion == 3 || numeroOperacion == 4)
            {
                // Se define la operacion aritmetica que se realizara.
                claseOperacion = numeroOperacion == 1 ? "Suma" : numeroOperacion == 2 ? "Resta" : numeroOperacion == 3 ? "Multiplicacion" : "Division";
                // Se solicitan datos de ingreso para ser procesados.
                Console.WriteLine("Ingresar el primer numero para la {0}: ", claseOperacion);
                string dato1 = Console.ReadLine();
                int numero1 = int.Parse(dato1);
                Console.WriteLine("Ingresar el segundo numero para la {0}: ", claseOperacion);
                string dato2 = Console.ReadLine();
                int numero2 = int.Parse(dato2);
                Console.WriteLine("El resultado de la {0} es: ", claseOperacion);
                // logica que establece el metodo de la operacion aritmetica que se aplicara.
                switch (numeroOperacion)
                {
                    case 1:
                        Console.WriteLine(Sumar(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine(Restar(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine(Multiplica(numero1, numero2));
                        break;
                    case 4:
                        Console.WriteLine(Dividir(numero1, numero2));
                        break;
                }
                // fin del programa.
                Console.WriteLine("Presiene cualquie tecla para finalizar...");
                Console.Read();
            }
            else
            {
                // fin del programa.
                Console.WriteLine("Opcion invalida, presione cualquier tecla para finalizar...");
                Console.Read();
            }


        }
        // Se utilizan cuatro metodos para el procesamiento dela informacion(suma, resta, multiplicacion, division).
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Restar(int numero1, int numero2)
        {
           return numero1 - numero2;
        }
        public static int Multiplica(int numero1, int numero2)
        {
           return numero1 * numero2;
        }

        public static double Dividir(double numero1, double numero2)
        {
           return numero1 / numero2;
        }

    }
}
