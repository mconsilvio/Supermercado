using System;
using System.Collections;

//Menu Clientes
namespace Supermercado
{
	public class iniciarCliente
	{
		//creo la funcion con los parametros que recibe de los otros menues
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			Console.WriteLine ("P R O D U C T O S [Compra-productos]");
			Console.WriteLine ("");
			Console.WriteLine ("Listado de productos: ");
			//lista los productos numerados 
			int i = 1;
			foreach (Producto cadaProducto in listaProductos) {
				Console.WriteLine (i + "--> " + cadaProducto.mostrarProducto ());
				i++;	
			}

			Console.WriteLine ("");
			Console.WriteLine ("----------------------------------------");
			Console.WriteLine ("Productos en el carrito");
			Console.WriteLine ("----------------------------------------");
			//crea un carrito
			Carrito carrito = new Carrito ();
			//si el objecto carrito tiene productos, llama a la funcion mostrarProdDelCarrito
			if (carrito.productosEnCarrito != null){
				carrito.mostrarProdDelCarrito ();
			}
			Console.WriteLine ("");
			Console.WriteLine ("Agregue un producto al carro o 0 para finalizar");
			string aPr= Console.ReadLine ();
			int agregarProducto = int.Parse (aPr);

			while (agregarProducto != 0){
				//obtiene el producto seleccionado en la posicion que selecciona el usuario
				Producto prodSeleccionado = (Producto)listaProductos [agregarProducto - 1];

				Console.WriteLine ("");
				Console.WriteLine ("¿Cuantas unidades desea agregar?");
				string cAg= Console.ReadLine ();
				int cantAgregar = int.Parse (cAg);
				//el objeto carrito llama a la funcion agregar y carga el producto mas la cantidad
				carrito.agregarProducto (prodSeleccionado,cantAgregar);

				Console.Clear ();
				Console.WriteLine ("P R O D U C T O S [Compra-productos]");
				Console.WriteLine ("");
				Console.WriteLine ("Listado de productos: ");

				//lista los productos numerados 
				i = 1;
				foreach (Producto cadaProducto in listaProductos) {
					Console.WriteLine (i + "--> " + cadaProducto.mostrarProducto ());
					i++;	
				}

				Console.WriteLine ("");
				Console.WriteLine ("----------------------------------------");
				Console.WriteLine ("Productos en el carrito");
				Console.WriteLine ("----------------------------------------");

				//si el objecto carrito tiene productos, llama a la funcion mostrarProdDelCarrito
				if (carrito.productosEnCarrito != null){
					carrito.mostrarProdDelCarrito ();
				}
				Console.WriteLine ("----------------------------------------");
				Console.WriteLine ("");
				Console.WriteLine ("Agregue un producto al carro o 0 para finalizar");
				aPr= Console.ReadLine ();
				agregarProducto = int.Parse (aPr);
			}

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