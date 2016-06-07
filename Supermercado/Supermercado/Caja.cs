using System;
using System.Collections;


namespace Supermercado
{
	public class Caja
	{
		private int CodigoCaja = 0;
		private bool Estado = false;
		private Cajero CajeroAcargo = null;

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

			return "Caja Nº: " + this.getCodigoCaja ()
				+ " --> Estado de la caja: " + est
				+ " --> Cajero a cargo: " + (string)this.getCajeroAcargo ().getNombre();
		}

	}
}


