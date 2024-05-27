using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int totalEntradasSol = 0, totalEntradasSombra = 0, totalEntradasPreferencial = 0;
            double acumuladoSol = 0, acumuladoSombra = 0, acumuladoPreferencial = 0;

            
            Console.Write("Ingrese número de factura: ");
            string numeroFactura = Console.ReadLine();

            Console.Write("Ingrese número de cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Ingrese nombre del comprador: ");
            string nombreComprador = Console.ReadLine();

            Console.Write("Ingrese localidad (1-Sol Norte/Sur, 2-Sombra Este/Oeste, 3-Preferencial): ");
            string inputLocalidad = Console.ReadLine();
            if (!int.TryParse(inputLocalidad, out int localidad) || localidad < 1 || localidad > 3)
            {
                Console.WriteLine("Localidad inválida");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese cantidad de entradas (máximo 4): ");
            string inputCantidadEntradas = Console.ReadLine();
            if (!int.TryParse(inputCantidadEntradas, out int cantidadEntradas) || cantidadEntradas < 1 || cantidadEntradas > 4)
            {
                Console.WriteLine("Cantidad de entradas inválida");
                Console.ReadLine();
                return;
            }

            
            double precioPorEntrada = 0;
            string nombreLocalidad = "";

            
            switch (localidad)
            {
                case 1:
                    precioPorEntrada = 10500;
                    nombreLocalidad = "Sol Norte/Sur";
                    break;
                case 2:
                    precioPorEntrada = 20500;
                    nombreLocalidad = "Sombra Este/Oeste";
                    break;
                case 3:
                    precioPorEntrada = 25500;
                    nombreLocalidad = "Preferencial";
                    break;
            }

            
            double subtotal = cantidadEntradas * precioPorEntrada;
            double cargosPorServicios = cantidadEntradas * 1000;
            double totalAPagar = subtotal + cargosPorServicios;

            
            if (localidad == 1)
            {
                totalEntradasSol += cantidadEntradas;
                acumuladoSol += subtotal;
            }
            else if (localidad == 2)
            {
                totalEntradasSombra += cantidadEntradas;
                acumuladoSombra += subtotal;
            }
            else if (localidad == 3)
            {
                totalEntradasPreferencial += cantidadEntradas;
                acumuladoPreferencial += subtotal;
            }

            
            Console.WriteLine("\nDatos de la venta:");
            Console.WriteLine($"Número de Factura: {numeroFactura}");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre Comprador: {nombreComprador}");
            Console.WriteLine($"Localidad: {nombreLocalidad}");
            Console.WriteLine($"Cantidad de Entradas: {cantidadEntradas}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Cargos por Servicios: {cargosPorServicios}");
            Console.WriteLine($"Total a Pagar: {totalAPagar}");

            
            MostrarEstadisticas(totalEntradasSol, acumuladoSol, totalEntradasSombra, acumuladoSombra, totalEntradasPreferencial, acumuladoPreferencial);

            
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadLine();
        }

        static void MostrarEstadisticas(int totalEntradasSol, double acumuladoSol, int totalEntradasSombra, double acumuladoSombra, int totalEntradasPreferencial, double acumuladoPreferencial)
        {
            Console.WriteLine("\nEstadísticas:");
            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {totalEntradasSol}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {acumuladoSol}");
            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {totalEntradasSombra}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {acumuladoSombra}");
            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {totalEntradasPreferencial}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {acumuladoPreferencial}");
        }
    }
}


