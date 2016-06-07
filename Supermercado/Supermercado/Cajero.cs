using System;
using System.Collections;


namespace Supermercado
{
	public class Cajero : Persona
	{
		private string horario= null;
		private int CodigoCajero = 0;

		public string getHorario(){
			return this.horario;
		}

		public void setHorario(string nuevoHorario){
			this.horario = nuevoHorario;
		}

		public int getCodigoCajero(){
			return this.CodigoCajero;
		}

		public void setCodigoCajero(int nuevoCodigoCajero){
			this.CodigoCajero = nuevoCodigoCajero;
		}

		public string mostrarCajero(){
			return "Nombre: " + this.getNombre () + " Apellido: " + this.getApellido ()
			+ " DNI: " + this.getDni().ToString( ) + " Código del cajero: " + this.getCodigoCajero ()
			+ " Horario: " + this.getHorario () ;
		}


	}
}




