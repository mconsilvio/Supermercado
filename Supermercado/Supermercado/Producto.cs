using System;
using System.Collections;


namespace Supermercado
{
	public class Producto
	{
		private string tipo = null;
		private string marca= null;
		private string envase= null;
		private float precio= 0;

		public string getTipo(){
			return this.tipo;
		}

		public void setTipo(string nuevotipo){
			this.tipo = nuevotipo;
		}

		public string getMarca(){
			return this.marca;
		}

		public void setMarca(string nuevaMarca){
			this.marca = nuevaMarca;
		}

		public string getEnvase(){
			return this.envase;
		}

		public void setEnvase(string nuevoEnvase){
			this.envase = nuevoEnvase;
		}

		public float getPrecio(){
			return this.precio;
		}

		public void setPrecio(float nuevoPrecio){
			this.precio = nuevoPrecio;
		}

		public string mostrarProducto(){
			return "Tipo: " + this.getTipo () + " Marca: " + this.getMarca () 
				+ " Envase: " + "<" + this.getEnvase () + ">" + " Precio: " + "$" + this.getPrecio().ToString();
		}


	}
}


