using System;
using System.Collections;


namespace Supermercado
{
	public class Cajero : Persona
	{
		private string horario= null;

		public string getHorario(){
			return this.horario;
		}

		public void setHorario(string nuevoHorario){
			this.horario = nuevoHorario;
		}

		public string mostrarCajero(){
			return "Nombre: " + this.getNombre () + " Apellido: " + this.getApellido ()
			+ " DNI: " + this.getDni().ToString( ) + " Horario: " + this.getHorario () ;
		}


	}
}




