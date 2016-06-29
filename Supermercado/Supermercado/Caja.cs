using System;
using System.Collections;

//funcion de Caja
namespace Supermercado
{
	public class Caja
	{
		//atributos
		private int CodigoCaja = 0;
		private bool Estado = false;
		private Cajero CajeroAcargo;
		private double Recaudacion = 0.0;

		//metodos
		public Caja (int CodigoCaja){
			this.CodigoCaja = CodigoCaja;
		}

		public int getCodigoCaja(){
			return this.CodigoCaja;
		}
		public bool getEstado(){
			return this.Estado;
		}

		public void setEstado(bool nuevoEstado){
			this.Estado = nuevoEstado;
		}

		public Cajero getCajeroAcargo(){
			return this.CajeroAcargo;
		}
		public void setCajeroAcargo(Cajero nuevoCajeroAcargo){
			this.CajeroAcargo = nuevoCajeroAcargo;
		}

		public string verCaja(){
			string est;

			if (this.getEstado ()) {
				est = "Abierta";
			} else {
				est = "Cerrada";
			}

			if (this.CajeroAcargo != null) {
				Cajero cajero = this.getCajeroAcargo ();

				return "Caja Nº: " + this.getCodigoCaja ()
				+ " --> Estado de la caja: " + est
					+ " --> Cajero a cargo: " + (string)cajero.getNombre () + " " + cajero.getApellido ();
			} else {
				return "Caja Nº: " + this.getCodigoCaja ()
				+ " --> Estado de la caja: " + est;
			}
		}

		public double getRecaudacion(){
			return this.Recaudacion;
		}
		public void agregarRecaudacion(double monto){
			this.Recaudacion += monto;
		}
	}
}