using System;
using System.Collections;

//Menu Productos y Promociones
namespace Supermercado
{
	public class iniciarProducto
	{
		//creo la funcion con los parametros que recibe de los otros menues
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
			long accion = long.Parse (ac);

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
					long precio = long.Parse (pr);

					//crea producto, los setea y lo agrega a listaProductos
					Producto producto = new Producto ();
					producto.setTipo (tipo);
					producto.setMarca (marca);
					producto.setEnvase (envase);
					producto.setPrecio (precio);
					listaProductos.Add (producto);

					Console.Clear();
					Console.WriteLine ("P R O D U C T O S [carga-productos]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para continuar:");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					Console.WriteLine ("Carga exitosa.");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 2:
					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [Carga-promociones]");
					Console.WriteLine ("");
					Console.WriteLine ("Listado de productos: ");
					int i = 1;
					//lista los productos
					foreach (Producto cadaProducto in listaProductos) {
						Console.WriteLine (i + "--> " + cadaProducto.mostrarProducto ());
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

					//obtiene el producto en la posicion que selecciona el usuario
					Producto prodSeleccionado = (Producto)listaProductos [idProducto - 1];
					//obtiene el tipo y marca que el usuario eligio
					string tipoSeleccionado = prodSeleccionado.getTipo ();
					string marcaSeleccionado = prodSeleccionado.getMarca ();
					//bool para verificar si existe la promocion en la lista de promociones
					bool existe = false;
					//busca en la lista el tipo y marca para compararlas con las ingresadas por el usuario
					foreach (Promocion cadaPromo in listaPromociones) {
						//toma cada producto de cada promo
						Producto prodActual = cadaPromo.getProducto ();
						//crea variables del tipo y marca del producto de cada promocion para luego comparar
						string tipoActual = prodActual.getTipo ();
						string marcaActual = prodActual.getMarca ();
						//compara y de ser igual remplaza los parametros
						if (tipoSeleccionado == tipoActual && marcaSeleccionado == marcaActual) {
							cadaPromo.setCantidadLLevar (cantidadLlevar);
							cadaPromo.setCantidadPagar (cantidadPagar);
							//setea el true para avisar que ya existe
							existe = true;
						}
					}
					if (existe == false) {
						//crea promocion, la setea y la agrega a listaPromociones
						Promocion promocion = new Promocion ();
						promocion.setProducto ((Producto)listaProductos [idProducto - 1]);
						/* agarra el idProducto y le resta 1 porque 
						 * el menu muestra los productos a partir de 1
						 * y la lista arranca en 0 */
						promocion.setPromocion (cantidadLlevar, cantidadPagar);
						//y agrega una nueva en caso de que no exista la anterior
						listaPromociones.Add (promocion);
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
					accion = long.Parse (ac);
					break;

				case 3:
					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [lista-productos]");
					Console.WriteLine ("");
					foreach (Producto producto2 in listaProductos) {
						Console.WriteLine (producto2.mostrarProducto ());
						Console.WriteLine ("");
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
					accion = long.Parse (ac);
					break;

				case 4:

					Console.Clear ();
					Console.WriteLine ("P R O D U C T O S [lista-promociones]");
					Console.WriteLine ("");
					foreach (Promocion promo1 in listaPromociones) {
						Console.WriteLine (promo1.verPromos ());
						Console.WriteLine ("");
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
					accion = long.Parse (ac);
					break;

				default:
					Console.Clear();
					Console.WriteLine ("P R O D U C T O S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número para continuar");
					Console.WriteLine ("1 --> Cargar un producto");
					Console.WriteLine ("2 --> Cargar un promoción");
					Console.WriteLine ("3 --> Listar los productos");
					Console.WriteLine ("4 --> Listar las promociones");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					Console.WriteLine ("El número ingresado no es valido, vuelva a ingresar:");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				}	
			}
			Console.Clear ();
			//pasa parametros a la funcion volverSupermercado
			this.volverSupermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
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


