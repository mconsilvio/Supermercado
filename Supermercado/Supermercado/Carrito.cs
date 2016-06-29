using System;
using System.Collections;

//funcion de Carrito
namespace Supermercado
{
	public class Carrito
	{	
		//atributos
		public ArrayList productosEnCarrito = new ArrayList();
		public double totalAPagar = 0.0;
		public double sinDesc = 0.0;
		public double ahorro = 0.0;
		public double tot = 0.0;

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

		//Calculadora para calcular el total a pagar con promocion y el monto que se ahorra con la promo
		//creo la funcion con la lista de promociones como parametro
		public ArrayList calcularPromoRecursiva(ArrayList listaPromociones){
			//Caso base de la recursividad, verifico si el carrito está vacío
			//si lo está retorno el total a pagar y el ahorro
			if (this.productosEnCarrito.Count == 0) {
				ArrayList pagoYAhorro = new ArrayList ();
				pagoYAhorro.Add (this.totalAPagar);
				pagoYAhorro.Add(this.ahorro);
				return pagoYAhorro;

			} else {

				//Si el carrito no está vacío, tomo el primer producto y su cantidad
				//y realizo los calculos pertinentes para retornar el ahorro y la 
				//cantidad a pagar.

				Promocion promocion=null;
				//me va a devolver otra lista con producto y cantidad
				ArrayList elProducto = (ArrayList)this.productosEnCarrito[0];
				Producto prodSeleccionado = (Producto)elProducto [0];
				int cantProducto = (int)elProducto [1];
				//recorre promo en la lista de promociones y carga la promo en producto
				//luego compara los get de producto con los get del producto seleccionado
				//si todos los parametros son iguales carga promo en promocion
				foreach (Promocion promo in listaPromociones) {
					Producto producto = (Producto)promo.getProducto ();
					if (producto.getTipo () == prodSeleccionado.getTipo ()
						&& producto.getMarca () == prodSeleccionado.getMarca ()
						&& producto.getEnvase () == prodSeleccionado.getEnvase ()) {
						promocion = promo; 
					}
				}
				//declara las variables con los valores que le corresponden
				int cantLlevar = promocion.getCantidadLLevar ();
				int cantPagar = promocion.getCantidadPagar ();
				double precioProducto = prodSeleccionado.getPrecio ();

				//pregunta si el producto entra en la promocion
				if (cantProducto < cantLlevar) {
					//si no entra hace el precio por el producto
					this.totalAPagar += (precioProducto * cantProducto);
				} else {
					//si entra hace los calculos para que me de el precio con la promocion incluida
					this.totalAPagar += ((precioProducto * cantPagar) * (cantProducto / cantLlevar))
						+ ((cantProducto % cantLlevar) * precioProducto);
				}
				//agarra el precio de producto y lo multiplica por la cantidad
				this.sinDesc += (precioProducto * cantProducto) ;

				//hace el total a pagar menos el descuento para saber cuanto se ahorro
				this.ahorro = sinDesc - totalAPagar;
				//la lista que contiene el total a pagar con el descuento y el ahorro
				ArrayList pagoYAhorro = new ArrayList();
				pagoYAhorro.Add(this.totalAPagar);
				pagoYAhorro.Add (this.ahorro);
				//return pagoYAhorro;

				//elimino el producto que ya calculé para llegar al caso base
				this.productosEnCarrito.RemoveAt(0);
				return calcularPromoRecursiva(listaPromociones);

			}
		}
	}
}


