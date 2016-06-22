using System;
using System.Collections;

//funcion de Cajero hereda de Persona
namespace Supermercado
{
	public class Cajero : Persona
	{
		//atributos
		private string horario= null;
		private int CodigoCajero;

		//metodos
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