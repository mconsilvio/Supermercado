using System;
using System.Collections;

//funcion de Persona
namespace Supermercado
{
	public class Persona
	{
		//atributos
		private string nombre = null;
		private string apellido= null;
		private string dni = null;

		private double Recaudacion = 0.0;

		//metodos
		public string getNombre(){
			return this.nombre;
		}
		public void setNombre(string nuevoNombre){
			this.nombre = nuevoNombre;
		}

		public string getApellido(){
			return this.apellido;
		}
		public void setApellido(string nuevoApellido){
			this.apellido = nuevoApellido;
		}
			
		public string getDni(){
			return this.dni;
		}
		public void setDni(string nuevoDni){
			this.dni = nuevoDni;
		}

		public string mostrarPersona(){
			return "Nombre: " + this.getNombre () + " Apellido: " + this.getApellido ()
			+ " DNI: " + this.getDni();
		}

		public double getRecaudacion(){
			return this.Recaudacion;
		}

		public void agregarRecaudacion(double monto){
			this.Recaudacion += monto;
		}
	}
}




