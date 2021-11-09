using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Trabajo_final.Clases;

namespace Trabajo_final
{
    class Program:Datos
    {
    
    /*Hacer un programa que permita registrar usuarios y loguearlos, una vez logueados muestre los datos del usuario.
    
    NOTA: EL PROGRAMA NO DEBE PARAR SU EJECUCION AUTOMATICAMENTE
    */
       
         public static void Login(Usuario1 [] U1)
        {

            bool acceso = false;
            long username = 0;
            int contrasena = 0;
            
            

            do
            {
                int c = 0;
                Console.Clear();
                Console.WriteLine("DATO IMPORTANTE: EL NOMBRE DE USUARIO ES EL NUMERO DE CEDULA SIN GUIONES ");
            Vuelve:
                try
                {
                    Console.Write("Ingrese su nombre de usuario: ");
                    username = long.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("ERROR ");
                    Console.WriteLine("DATO ERRONEO ");
                    Console.WriteLine("Pulse Enter para ingresar el dato nuevamente...");
                    goto Vuelve;
                }

                Console.WriteLine();
            Vuelve1:
                try
                {
                    Console.Write("Ingrese su contraseña: ");
                    contrasena = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("ERROR ");
                    Console.WriteLine("DATO ERRONEO ");
                    Console.WriteLine("Pulse Enter para ingresar el dato nuevamente...");
                    goto Vuelve1;
                }


                for (int i = 0; i < 4; i++)
                {


                    if (username == U1[i].username)
                    {
                        if (contrasena == U1[i].clave)
                        {
                            if (U1[i].actividad==true)
                            {
                                acceso = true;
                                Console.WriteLine("ACCESO CONCEDIDO...");
                                Console.WriteLine("El nombre del usuario es: " + U1[i].Nombre);
                                Console.WriteLine("Su Usuario es: " + U1[i].username);
                                Console.WriteLine("Su rol es: " + U1[i].rol);
                                Console.WriteLine("La feca de creacion del usario es: " + U1[i].fecha_creacion.ToShortDateString());
                                Console.WriteLine("Su estado de actividad es: " + U1[i].actividad);
                                Vuelta(U1);
                            }
                            else
                            {
                                Console.WriteLine("El usuario {0} está inactivo  ",U1[i].username);
                                Console.WriteLine("Valide otro Usuario...");
                                Console.WriteLine("PULSE ENTER PARA CONTINUAR");
                                Console.ReadLine();
                            }
                          
                        }
                        else
                        {
                            c++;
                        }
                    }
                    else
                    {
                        c++;
                    }
                }
                if (c==4)
                {
                    TimeSpan dormida = new TimeSpan(0, 0, 2);
                    Console.WriteLine("Dato de Usuario Incorrecto");
                    Console.WriteLine("Espere 2 segundo para volver a intentarlo ");
                    Thread.Sleep(dormida);
                    
                }
               
            } while (acceso == false );

        }
        public static void Vuelta(Usuario1[] U1)
        {
            string vuelta = "";
            Console.WriteLine("¿Desea validar otro usuario? Digite (si) o (no)");
            vuelta = Console.ReadLine();

            switch(vuelta)
            {
                case "si":
                    Login(U1);
                    break;
                case "Si":
                    Login(U1);
                    break;
                case "SI":
                    Login(U1);
                    break;
                case "no":
                    Console.WriteLine("CERRANDO EL PROGRAMA...");
                    Console.WriteLine("Pulse Enter...");
                    break;
                case "No":
                    Console.WriteLine("CERRANDO EL PROGRAMA...");
                    Console.WriteLine("Pulse Enter...");
                    break;
                case "NO":
                    Console.WriteLine("CERRANDO EL PROGRAMA...");
                    Console.WriteLine("Pulse Enter...");
                    break;
                default:
                    Console.WriteLine("Dato Erroneo ingresado");
                    Vuelta(U1);
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            
            Datos.Usuarios();

            Console.ReadKey();

        }
    }
}
