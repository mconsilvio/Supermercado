﻿using System;
using System.Collections;

//funcion de Cliente hereda de Persona
namespace Supermercado
{
	public class Cliente : Persona
	{
		//atributos
		private string nacimiento = null;
		// private Carrito carrito = null;

		//metodos
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
		// public void setCarrito (Carrito carrito){
		//	this.carrito = carrito;
		// }
	}
}




