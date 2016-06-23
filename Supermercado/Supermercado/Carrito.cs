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

		public double calcularTotal (ArrayList listaPromociones){

			double totalAPagar = 0.0;

			foreach (ArrayList prodEnCarrito in this.productosEnCarrito) {
				Promocion promocion=null;

				Producto prodSeleccionado = (Producto)prodEnCarrito [0];
				int cantProducto = (int)prodEnCarrito [1];

				foreach (Promocion promo in listaPromociones) {
					Producto producto = (Producto)promo.getProducto ();
					if (producto.getTipo () == prodSeleccionado.getTipo () && producto.getMarca () == prodSeleccionado.getMarca () && producto.getEnvase () == prodSeleccionado.getEnvase ()) {
						promocion = promo; 
					}
				}

				int cantLlevar = promocion.getCantidadLLevar ();
				int cantPagar = promocion.getCantidadPagar ();
				double precioProducto = prodSeleccionado.getPrecio ();
				if (cantProducto < cantLlevar) {
					totalAPagar += (precioProducto * cantProducto);
				} else {
					totalAPagar += ((precioProducto * cantPagar) * (cantProducto / cantLlevar)) + ((cantProducto % cantLlevar) * precioProducto);
				} //agregar que muestre sin promocion
			}

			return totalAPagar;
		


		}
	}
}
