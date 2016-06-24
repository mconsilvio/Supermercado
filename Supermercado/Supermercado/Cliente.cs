using System;
using System.Collections;

//funcion de Cliente hereda de Persona
namespace Supermercado
{
	public class Cliente : Persona
	{
		//atributos
		private string nacimiento = null;

		//metodos
		public string getNacimiento(){
			return this.nacimiento;
		}
		public void setNacimiento(string nuevoNacimiento){
			this.nacimiento = nuevoNacimiento;
		}

		public string mostrarCliente(){
			return "Cliente: " + this.getNombre () + " " + this.getApellido ();
		}
	}
}