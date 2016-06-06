using System;
using System.Collections;

namespace Supermercado
{
	public class MainClass
	{
		public static void Main (string[] args)
		{	
			ArrayList listaProductos = new ArrayList();
			ArrayList listaPromociones = new ArrayList ();
			Console.WriteLine ("S U P E R M E R C A D O");
			Console.WriteLine ("");
			Console.WriteLine ("Ingrese un número para acceder al módulo deceado:");
			Console.WriteLine ("1 --> Productos");
			Console.WriteLine ("2 --> Cajas");
			Console.WriteLine ("3 --> Cliente");
			Console.WriteLine ("4 --> Administración");
			Console.WriteLine ("5 --> Salir del sistema");
			Console.WriteLine ("");

			string ac = Console.ReadLine();
			int accion = int.Parse (ac);

			while (accion != 5)
			{
				switch (accion){
				case 1:
					Console.Clear ();
					iniciarProducto moduloProducto = new iniciarProducto ();
					moduloProducto.iniciar ();

					break;

				case 2:
					Console.Clear ();
					iniciarCaja moduloCajas = new iniciarCaja ();
					moduloCajas.iniciar ();

					break;

				case 3:
					Console.Clear ();

					break;

				case 4:
					Console.Clear ();

					break;

				default:
					Console.Clear();
					Console.WriteLine ("S U P E R M E R C A D O");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número para acceder al módulo deceado:");
					Console.WriteLine ("1 --> Productos");
					Console.WriteLine ("2 --> Cajas");
					Console.WriteLine ("3 --> Cliente");
					Console.WriteLine ("4 --> Administración");
					Console.WriteLine ("5 --> Salir del sistema");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = int.Parse (ac);
					break;

				}	
			}
			Console.Clear();
			Console.WriteLine ("Fin del Programa");
			Console.WriteLine ("");
			Console.WriteLine ("Good bye!");
		}
	}
}