using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////=====================================ARRAY==================================
            //int[] numeros = new int[3];
            //for (int i = 0; i < 3; i++) {
            //    Console.WriteLine("ingrese numero " + (i +1)+ ": ");
            //    numeros[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("\n numeros ingresados");
            //foreach (var item  in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            //int suma = 0;  
            //for (int i = 0;i < 3;i++)
            //{
            //    suma += numeros[i];
            //}
            //Console.WriteLine("la suma de los numeros ingresados es "+ suma);




            //------LISTA ---------


            //List<int> numeros = new List<int>();
            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);
            //Console.WriteLine("numeros en la lista");
            //foreach (var item in numeros) { 
            //    Console.WriteLine(item);
            //}
            //// aceder a un elemonto por su indice
            //int primerNumero = numeros[1];
            //Console.WriteLine($"el numero en la lista es: {primerNumero}");

            //// modificar un elemento en la lista 
            //numeros[2] = 400;
            //Console.WriteLine($"Numeros Modificado {numeros[2]}");

            ////insertar un elemento en una posicion especifica 
            //numeros.Insert(2, 15);
            //Console.WriteLine($"Numeros Modificado {numeros[2]}");

            ////eliminar un elemetno de la list especifica 
            //numeros.RemoveAt(1);

            ////eliminar un elemonto por su volor 
            //numeros.Remove(10);





            // PROBLEA USUARIO/PRODUCTO
            List<string> productos = new List<string>();
            List<double> precios = new List<double>();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÃš DE PRODUCTOS ---");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Actualizar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opciÃ³n: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio del producto: ");
                        double precio = double.Parse(Console.ReadLine());

                        productos.Add(nombre);
                        precios.Add(precio);
                        Console.WriteLine(" Producto agregado correctamente.");
                        break;

                    case 2:
                        Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
                        for (int i = 0; i < productos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]}");
                        }
                        break;

                    case 3:
                        Console.Write("NÃºmero del producto a actualizar: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;

                        if (pos >= 0 && pos < productos.Count)
                        {
                            Console.Write("Nuevo nombre: ");
                            productos[pos] = Console.ReadLine();
                            Console.Write("Nuevo precio: ");
                            precios[pos] = double.Parse(Console.ReadLine());
                            Console.WriteLine("Producto actualizado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine(" Producto no encontrado.");
                        }
                        break;

                    case 4:
                        Console.Write("NÃºmero del producto a eliminar: ");
                        int eliminar = int.Parse(Console.ReadLine()) - 1;

                        if (eliminar >= 0 && eliminar < productos.Count)
                        {
                            productos.RemoveAt(eliminar);
                            precios.RemoveAt(eliminar);
                            Console.WriteLine("Producto eliminado.");
                        }
                        else
                        {
                            Console.WriteLine(" No existe ese producto.");
                        }
                        break;

                    case 5:
                        Console.WriteLine(" Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("OpciÃ³n no vÃ¡lida.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
