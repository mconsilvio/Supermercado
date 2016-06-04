using System;
using System.Collections;


namespace Supermercado
{
	public class Cliente : Persona
	{
		private string nacimiento= null;

		public string getNacimiento(){
			return this.nacimiento;
		}

		public void setNacimiento(string nuevoNacimiento){
			this.nacimiento = nuevoNacimiento;
		}

		public string mostrarCajero(){
			return "Nombre: " + this.getNombre () + " Apellido: " + this.getApellido ()
			+ " DNI: " + this.getDni().ToString() + " Fecha de Nacimiento: " + this.getNacimiento();
		}


	}
}




