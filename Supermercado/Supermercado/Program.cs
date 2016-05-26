using System;
using System.Collections;

namespace Supermercado
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			ArrayList listaProductos = new ArrayList();

			Console.WriteLine ("P R O D U C T O S");
			Console.WriteLine ("");
			Console.WriteLine ("Ingrese un número");
			Console.WriteLine ("1 --> Cargar un producto");
			Console.WriteLine ("2 --> Cargar un promoción");
			Console.WriteLine ("3 --> Listar los productos");
			Console.WriteLine ("4 --> Listar las promociones");
			Console.WriteLine ("5 --> Volver al menu principal");
			Console.WriteLine ("");

			string ac = Console.ReadLine();
			int accion = int.Parse (ac);

			while (accion != 5)
			{
				switch (accion){
					case 1:
						Console.Clear();
						Console.WriteLine ("P R O D U C T O S [Carga-productos]");
						Console.WriteLine ("");
						Console.Write ("Ingrese tipo de producto: ");
						string tipo = Console.ReadLine ();
						Console.Write ("Ingrese marca de producto: ");
						string marca = Console.ReadLine ();
						Console.Write ("Ingrese envase de producto: ");
						string envase = Console.ReadLine ();
						Console.Write ("Ingrese Precio: ");

						string pr = Console.ReadLine ();
						float precio = float.Parse (pr);

						Producto producto = new Producto ();
						producto.setTipo (tipo);
						producto.setMarca (marca);
						producto.setEnvase (envase);
						producto.setPrecio (precio);
						listaProductos.Add (producto);

						Console.Clear();
						Console.WriteLine ("P R O D U C T O S [carga-productos]");
						Console.WriteLine ("");
						Console.WriteLine ("Carga exitosa.");
						Console.WriteLine ("Ingrese otro número para continuar:");
						Console.WriteLine ("1 --> Cargar un producto");
						Console.WriteLine ("2 --> Cargar un promoción");
						Console.WriteLine ("3 --> Listar los productos");
						Console.WriteLine ("4 --> Listar las promociones");
						Console.WriteLine ("5 --> Volver al menu principal");
						Console.WriteLine ("");
						ac = Console.ReadLine();
						accion = int.Parse (ac);

						break;
					case 2:
						Console.Clear();
						Console.WriteLine ("P R O D U C T O S [Carga-promociones]");
						Console.WriteLine ("");

						Console.WriteLine ("Listado de productos: ");
						int i=1;
						foreach (Producto producto2 in listaProductos){
							Console.WriteLine(i + "--> " + producto2.mostrarProducto());
							i++ ;	
						}

						Console.WriteLine ("");
						Console.WriteLine ("Seleccione el producto para la promoción");

						break;

					case 3:
						Console.Clear();
						Console.WriteLine ("P R O D U C T O S [lista-productos]");
						Console.WriteLine ("");
						foreach (Producto producto2 in listaProductos){
							Console.WriteLine(producto2.mostrarProducto());
						}
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
						Console.Clear();
						Console.WriteLine ("P R O D U C T O S [lista-promociones]");
						Console.WriteLine ("");
						foreach (Producto producto3 in listaProductos){
							Console.WriteLine(producto3.mostrarProducto());
						}
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