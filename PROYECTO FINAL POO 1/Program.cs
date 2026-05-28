using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_POO_1 //VENTA DE COMIDA DOÑA SHENI 
{
	public class cliente
	{
		private string nombre;
		private int codigo;
		private int telefono;
		private string correo;

		public string Nombre
		{
			get{ return nombre; }
			set { nombre = value; }
		}
		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }

		}
		public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}

		public string RegistrarNombre()
		{
			Console.WriteLine("ingrese el nombre del cliente: ");
			return nombre;
		}

	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("  BIENVENIDOS AL MENU DE DOÑA SHENI  ");
			Console.ReadLine();

			int opcion = 0;

			do
			{
				Console.WriteLine("Seleccione una opcion del menu: ");
				Console.WriteLine("1. Ver menu de alimentos: ");
				Console.WriteLine("2. Hacer un pedido: ");
				Console.WriteLine("3. Calcular total: ");
				Console.WriteLine("4. Ver pedidos: ");
				Console.WriteLine("5. Buscar pedidos: ");
				Console.WriteLine("6. Cancelar pedido: ");
				Console.WriteLine("7. salir: ");
				opcion = int.Parse(Console.ReadLine());

				switch (opcion)
				{
					case 1:
						Console.WriteLine("Las opciones de los alimentos dependen si hay existentes: ");
						break;
					case 2:
						Console.WriteLine("Ingrese lo que desea consumir: ");
						break;
					case 3:
						Console.WriteLine("ingrese su numero de orden para digitalizar su total: ");
						break;
					case 4:
						Console.WriteLine("Total vendido: ");
						break;
					case 5:
						Console.WriteLine("Ingrese el numero de orden para buscar su pedido: ");
						break;
					case 6:
						Console.WriteLine("Ingrese el numero de orden para cancelar su pedido: ");
						break;
					case 7:
						Console.WriteLine("Gracias por su compra vuelva pronto: "); 
						break;
					default:
						Console.WriteLine("Selecciono una opcion invalida, intente de nuevo: ");
						break;
				}
				


			} while (opcion != 7);
				
		}
	}
}
