using System;
using System.Collections;

//Menu Principal
namespace Supermercado
{
	public class Supermercado
	{	
		//Crear nuevas listas de atributos vacios para la clase Supermercado
		ArrayList listaProductos = new ArrayList();
		ArrayList listaPromociones = new ArrayList ();
		ArrayList listaCajas = new ArrayList();
		ArrayList listaCajeros = new ArrayList ();

		//Creo el constructor Supermercado con los parametros que necesita, y recibe
		public Supermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			//reemplazo los atributos de las listas con los parametros recibidos
			this.listaProductos = listaProductos;
			this.listaPromociones = listaPromociones;
			this.listaCajas = listaCajas;
			this.listaCajeros = listaCajeros;
		}

		public void iniciar(){
			//instancio la funcion que trae las listas precargada
			preCarga pre = new preCarga ();
			//funcion que trae las cajas
			pre.preCargaCajas (listaProductos, listaPromociones, listaCajas, listaCajeros);
			//funcion que trae las productos
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
			long accion = long.Parse (ac);

			while (accion != 6)
			{
				switch (accion){
				case 1:
					Console.Clear (); 
					//inicia modulo producto
					iniciarProducto moduloProducto = new iniciarProducto ();
					moduloProducto.iniciar (this.listaProductos,this.listaPromociones,this.listaCajas,this.listaCajeros);
					break;

				case 2:
					Console.Clear ();
					//inicia modulo cajas
					iniciarCaja moduloCajas = new iniciarCaja ();
					moduloCajas.iniciar (this.listaProductos,this.listaPromociones,this.listaCajas,this.listaCajeros);
					break;

				case 3:
					Console.Clear ();
					//inicia modulo cliente
					iniciarCliente moduloCliente = new iniciarCliente ();
					moduloCliente.iniciar (this.listaProductos,this.listaPromociones,this.listaCajas,this.listaCajeros);
					break;

				case 4:
					Console.Clear ();
					break;

				case 5:
					Console.Clear ();
					Console.WriteLine ("Fin del Programa");
					Console.WriteLine ("");
					Console.WriteLine ("Good bye!");
					Environment.Exit (-1); //fin del programa
					break;

				default:
					Console.Clear();
					Console.WriteLine ("S U P E R M E R C A D O");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para acceder al módulo deceado:");
					Console.WriteLine ("1 --> Productos");
					Console.WriteLine ("2 --> Cajas");
					Console.WriteLine ("3 --> Cliente");
					Console.WriteLine ("4 --> Administración");
					Console.WriteLine ("5 --> Salir del sistema");
					Console.WriteLine ("");
					Console.WriteLine ("El número ingresado no es valido, vuelva a ingresar:");

					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				}	
			}
			Console.Clear();
			Console.WriteLine ("Fin del Programa");
			Console.WriteLine ("");
			Console.WriteLine ("Good bye!"); 
		}

		//volver al menu principal con las listas cargadas
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}
	}
}


