using System;
using System.Collections;

namespace Supermercado
{
	public class Supermercado
	{	
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}

		ArrayList listaProductos = new ArrayList();
		ArrayList listaPromociones = new ArrayList ();
		ArrayList listaCajas = new ArrayList();
		ArrayList listaCajeros = new ArrayList ();

		public Supermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			this.listaProductos = listaProductos;
			this.listaPromociones = listaPromociones;
			this.listaCajas = listaCajas;
			this.listaCajeros = listaCajeros;
		}

		public void iniciar(){
			
			preCarga pre = new preCarga ();
			pre.preCargaCajas (listaProductos, listaPromociones, listaCajas, listaCajeros);
			pre.preCargaProductos (listaProductos, listaPromociones, listaCajas, listaCajeros);


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

			while (accion != 6)
			{
				switch (accion){
				case 1:
					Console.Clear ();
					iniciarProducto moduloProducto = new iniciarProducto ();
					moduloProducto.iniciar (this.listaProductos,this.listaPromociones,this.listaCajas,this.listaCajeros);

					break;

				case 2:
					Console.Clear ();
					iniciarCaja moduloCajas = new iniciarCaja ();
					moduloCajas.iniciar (this.listaProductos,this.listaPromociones,this.listaCajas,this.listaCajeros);

					break;

				case 3:
					Console.Clear ();

					break;

				case 4:
					Console.Clear ();

					break;

				case 5:
					Console.Clear ();
					Console.WriteLine ("Fin del Programa");
					Console.WriteLine ("");
					Console.WriteLine ("Good bye!");
					Environment.Exit (-1);
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

