using System;
using System.Collections;


namespace Supermercado
{
	public class Caja
	{
		private int CodigoCaja = 0;
		private bool Estado = false;
		private string CajeroAcargo = null;

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

		public string getCajeroAcargo(){
			return this.CajeroAcargo;
		}

		public void setCajeroAcargo(string nuevoCajeroAcargo){
			this.CajeroAcargo = nuevoCajeroAcargo;
		}

		public string verCaja(){
			return "Codigo de la caja: " + this.getCodigoCaja ()
				+ " -> Estado de la caja: " + this.getEstado ()
				+ " -> Cajero a cargo: " + this.getCajeroAcargo () ;
		}

	}
}


