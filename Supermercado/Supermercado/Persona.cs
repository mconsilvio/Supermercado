using System;
using System.Collections;


namespace Supermercado
{
	public class Persona
	{
		private string nombre = null;
		private string apellido= null;
		private int dni = 0;

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
			
		public float getDni(){
			return this.dni;
		}

		public void setDni(int nuevoDni){
			this.dni = nuevoDni;
		}

		public string mostrarPersona(){
			return "Nombre: " + this.getNombre () + " Apellido: " + this.getApellido ()
			+ " DNI: " + this.getDni().ToString();
		}


	}
}




