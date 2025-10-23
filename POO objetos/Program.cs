using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el objeto auto
            //Auto miAuto = new Auto("Toyota", "Corolla", 2020, "messi");
            //miAuto.Mostrar_info();

            //Auto bus = new Auto("ferrari", "urus", 2025, "negro");
            //bus.Mostrar_info();

            //Auto camion = new Auto("ford", "f-150", 2025, "azul");
            //camion.Mostrar_info();

            //creamos el objeto Estudiante
            //Console.WriteLine("ingrse el nombre del estudainte");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("ingrse la edad del estudainte");
            //int edad = int.Parse(Console.ReadLine());

            //Estudiante estudiante1 = new Estudiante(nombre, edad);
            //estudiante1.VerificarEdad();



            //Producto 
            //ProductoCrud crud = new ProductoCrud();
            //int opcion = 0;

            //do
            //{
            //    Console.WriteLine("===== MENÚ DE PRODUCTOS =====");
            //    Console.WriteLine("1. Agregar producto");
            //    Console.WriteLine("2. Mostrar productos");
            //    Console.WriteLine("3. Actualizar producto");
            //    Console.WriteLine("4. Eliminar producto");
            //    Console.WriteLine("5. Salir");
            //    Console.Write("Seleccione una opción: ");

            //    int.TryParse(Console.ReadLine(), out opcion);
            //    Console.WriteLine();

            //    switch (opcion)
            //    {
            //        case 1:
            //            crud.AgregarProducto();
            //            break;
            //        case 2:
            //            crud.MostrarProductos();
            //            break;
            //        case 3:
            //            crud.ActualizarProducto();
            //            break;
            //        case 4:
            //            crud.EliminarProducto();
            //            break;
            //        case 5:
            //            Console.WriteLine(" Saliendo del programa...");
            //            break;
            //        default:
            //            Console.WriteLine(" Opción no válida.\n");
            //            break;
            //    }

            //} while (opcion != 5);




            // ejercicio con PERSONA 
            Console.WriteLine("=== PROGRAMA AGENDA ===");

            // Solicitar datos iniciales
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el género (F o M): ");
            string genero = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();

            // Crear el objeto Persona
            Persona persona = new Persona(nombre, edad, genero, telefono);

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Imprimir detalles");
                Console.WriteLine("2. Calcular edad en días");
                Console.WriteLine("3. Editar información");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        persona.ImprimirDetalles();
                        break;
                    case 2:
                        persona.CalcularEdadEnDias();
                        break;
                    case 3:
                        persona.EditarInformacion();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
    