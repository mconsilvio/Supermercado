using System;
using System.Collections;

//funcion de Carrito
namespace Supermercado
{
	public class Carrito
	{	
		//atributos
		public ArrayList productosEnCarrito = new ArrayList();


		//metodos
		public void agregarProducto(Producto prodSeleccionado, int cantAgregar){
			//guarda el producto y su cantidad en la lista unProductoEnCarrito
			ArrayList unProductoEnCarrito = new ArrayList ();
			unProductoEnCarrito.Add (prodSeleccionado);
			unProductoEnCarrito.Add (cantAgregar);

			//guarda la lista unProductoEnCarrito en la lista productosEnCarrito
			this.productosEnCarrito.Add (unProductoEnCarrito);
		}

		public void mostrarProdDelCarrito(){
			foreach(ArrayList listaProd in productosEnCarrito){
				Producto cadaProducto = (Producto)listaProd [0];

				string tipo = cadaProducto.getTipo ();
				string marca = cadaProducto.getMarca ();
				string envase = cadaProducto.getEnvase ();
				string cantidad = listaProd [1].ToString ();

				Console.WriteLine (tipo + " " + marca + " <" + envase + "> " + " <" + cantidad + " unidades>");
				
			}
			
		}


		/*public double calcularTotal (){
			if (productosEnCarrito == null) {
				return 0;
			} else {
				foreach (Producto producto in productosEnCarrito) {
				totalAPagar = (cantidadPagar / cantidadLLevar) + (cantidadPagar % cantidadLLevar);
			}
		}*/
	}
}
