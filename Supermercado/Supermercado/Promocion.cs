using System;
using System.Collections;


namespace Supermercado
{
	public class Promocion
	{
		private Producto producto;
		private int cantidadLLevar;
		private int cantidadPagar;

		public Producto getProducto(){
			return this.producto;
		}

		public void setProducto(Producto nuevoProducto){
			this.producto = nuevoProducto;
		}

		public int getCantidadLLevar(){
			return this.cantidadLLevar;
		}

		public void setCantidadLLevar(int nuevaCant){
			this.cantidadLLevar = nuevaCant;
		}

		public int getCantidadPagar(){
			return this.cantidadPagar;
		}

		public void setCantidadPagar(int nuevaCant){
			this.cantidadPagar = nuevaCant;
		}

		public void setPromocion(int cantLLevar,int cantPagar){
			this.setCantidadLLevar (cantLLevar);
			this.setCantidadPagar (cantPagar);
		}

		public string verPromos(){
			return this.producto.mostrarProducto () + " LLevas:" + this.cantidadLLevar.ToString ()
			+ " Pagas:" + this.cantidadPagar.ToString ();
		}

	}
}


