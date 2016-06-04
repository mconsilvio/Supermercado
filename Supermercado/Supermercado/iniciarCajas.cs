using System;
using System.Collections;


namespace Supermercado
{
	public class iniciarCajas
	{
		public iniciarCajas ()
		{
			ArrayList listaCajas = new ArrayList();
			ArrayList listaCajeros = new ArrayList ();
			Console.WriteLine ("C A J A S");
			Console.WriteLine ("");
			Console.WriteLine ("Ingrese un número:");
			Console.WriteLine ("1 --> Nuevo cajero");
			Console.WriteLine ("2 --> Abrir caja");
			Console.WriteLine ("3 --> Cerrar caja");
			Console.WriteLine ("4 --> Listado de cajas");
			Console.WriteLine ("5 --> Volver al menu principal");
			Console.WriteLine ("");

			string ac = Console.ReadLine();
			int accion = int.Parse (ac);

			while (accion != 5)
			{
				switch (accion){
				case 1:
					Console.Clear();
					Console.WriteLine ("C A J A S [Carga-cajero]");
					Console.WriteLine ("");
					Console.Write ("Ingrese el nombre: ");
					string nombre = Console.ReadLine ();
					Console.Write ("Ingrese el apellido: ");
					string apellido = Console.ReadLine ();
					Console.Write ("Ingrese el dni: ");
					string d = Console.ReadLine ();
					int dni = int.Parse (d);
					Console.Write ("Ingrese el horario de trabajo: ");
					string horario = Console.ReadLine ();


					Cajero cajero = new Cajero ();
					cajero.setNombre (nombre);
					cajero.setApellido (apellido);
					cajero.setDni (dni);
					cajero.setHorario (horario);
					listaCajeros.Add (cajero);

					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");

					ac = Console.ReadLine();
					accion = int.Parse (ac);

					break;

				case 2:
					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [Carga-promociones]");
					Console.WriteLine ("");

					Console.WriteLine ("Listado de productos: ");
					int i = 1;
					foreach (Producto producto2 in listaProductos) {
						Console.WriteLine (i + "--> " + producto2.mostrarProducto ());
						i++;	
					}

					Console.WriteLine ("");
					Console.WriteLine ("Seleccione el producto para la promoción");
					string idProd = Console.ReadLine ();
					int idProducto = int.Parse (idProd);
					Console.WriteLine ("Ingrese cantidad a llevar:");
					string cantLLevar = Console.ReadLine ();
					int cantidadLlevar = int.Parse (cantLLevar);
					Console.WriteLine ("Ingrese cantidad a pagar:");
					string cantPagar = Console.ReadLine ();
					int cantidadPagar = int.Parse (cantPagar);

					Promocion promocion = new Promocion ();

					promocion.setProducto ((Producto)listaProductos [idProducto - 1]);
					promocion.setPromocion (cantidadLlevar, cantidadPagar);

					listaPromociones.Add (promocion);

					Console.Clear();
					Console.WriteLine ("P R O D U C T O S [carga]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para continuar");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = int.Parse (ac);
					break;

				case 3:
					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [lista-productos]");
					Console.WriteLine ("");
					foreach (Producto producto2 in listaProductos) {
						Console.WriteLine (producto2.mostrarProducto ());
					}
					Console.ReadKey (true);
					Console.Clear();
					Console.WriteLine ("P R O D U C T O S [carga]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para continuar");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = int.Parse (ac);
					break;
				case 4:

					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [lista-promociones]");
					Console.WriteLine ("");
					foreach (Promocion promo1 in listaPromociones) {
						Console.WriteLine (promo1.verPromos ());
					}
					Console.WriteLine ("Presione alguna tecla para volver...");
					string sasa = Console.ReadLine ();
					Console.Clear();
					Console.WriteLine ("P R O D U C T O S [carga]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para continuar");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = int.Parse (ac);
					break;


				default:
					Console.Clear();
					Console.WriteLine ("P R O D U C T O S");
					Console.WriteLine ("");
					Console.WriteLine ("Se ingreso un valor fuera de rango");
					Console.WriteLine ("Ingrese otro número para continuar");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = int.Parse (ac);
					break;

				}	
			}
			Console.Clear();
			Console.WriteLine ("M O D U L O S");
			Console.WriteLine ("");
			Console.WriteLine ("menu principal");
		}
	}
}

