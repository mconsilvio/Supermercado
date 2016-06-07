using System;
using System.Collections;


namespace Supermercado
{
	public class iniciarProducto
	{
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
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
					Console.ReadLine ();

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
			Console.Clear ();
			this.volverSupermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);

		}
	}
}


