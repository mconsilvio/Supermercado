using System;
using System.Collections;

//funcion de Producto
namespace Supermercado
{
	public class Producto
	{
		//atributos
		private string tipo = null;
		private string marca = null;
		private string envase = null;
		private double precio = 0;

		//metodos
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

		public double getPrecio(){
			return this.precio;
		}
		public void setPrecio(double nuevoPrecio){
			this.precio = nuevoPrecio;
		}

		public string mostrarProducto(){
			return "Tipo: " + this.getTipo () + " Marca: " + this.getMarca () 
				+ " Envase: " + "<" + this.getEnvase () + ">" + " Precio: " + "$" + this.getPrecio().ToString();
		}
	}
}


