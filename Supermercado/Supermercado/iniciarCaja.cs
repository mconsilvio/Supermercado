using System;
using System.Collections;

//Menu Cajas y Cajeros
namespace Supermercado
{
	public class iniciarCaja
	{
		//creo la funcion con los parametros que recibe de los otros menues
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros, ArrayList listaClientes)
		{
			Console.WriteLine ("C A J A S");
			Console.WriteLine ("");
			Console.WriteLine ("Ingrese un número:");
			Console.WriteLine ("1 --> Nuevo cajero");
			Console.WriteLine ("2 --> Abrir caja");
			Console.WriteLine ("3 --> Cerrar caja");
			Console.WriteLine ("4 --> Listado de cajas");
			Console.WriteLine ("5 --> Volver al menu principal");
			Console.WriteLine ("");
			string ac = Console.ReadLine();
			long accion = long.Parse (ac);

			while (accion != 5)
			{
				switch (accion){
				case 1:
					Console.Clear ();
					Console.WriteLine ("C A J A S [Carga-cajero]");
					Console.WriteLine ("");
					Console.Write ("Ingrese el nombre: ");
					string nombre = Console.ReadLine ();
					Console.Write ("Ingrese el apellido: ");
					string apellido = Console.ReadLine ();
					Console.Write ("Ingrese el dni: ");
					string dni = Console.ReadLine ();
					Console.Write ("Ingrese el horario de trabajo: ");
					string horario = Console.ReadLine ();
					int cantidadCajeros = listaCajeros.Count;

					//crea un cajero, los setea y lo agrega a listaCajeros
					Cajero cajero = new Cajero ();
					cajero.setCodigoCajero (cantidadCajeros+1);
					cajero.setNombre (nombre);
					cajero.setApellido (apellido);
					cajero.setDni (dni);
					cajero.setHorario (horario);
					listaCajeros.Add (cajero);

					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 2:
					Console.Clear ();
					Console.WriteLine ("C A J A S [Abrir-caja]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese el número de la caja a abrir [del 1 al 5]:");
					string CodCaja = Console.ReadLine ();
					int CodigoCaja = int.Parse (CodCaja);

					Console.Clear ();
					Console.WriteLine ("C A J A S [Abrir-caja]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese el Nº del cajero a cargo:");
					Console.WriteLine ("");
					Console.WriteLine ("Lista de cajeros cargados:");
					//lista los cajeros
					foreach (Cajero cajero1 in listaCajeros) {
						Console.WriteLine ("Nº" + cajero1.getCodigoCajero() + " " + cajero1.getApellido () + ", " + cajero1.getNombre () + ".");
					}
					Console.WriteLine ("");
					string CajeroAcargo = Console.ReadLine ();
					int codigoCajero = int.Parse(CajeroAcargo);
					Caja cajaASetear = null;

					foreach (Caja caja in listaCajas) {
						if (caja.getCodigoCaja () == CodigoCaja) {
							cajaASetear = caja;
						}
					}

					if (cajaASetear.getCajeroAcargo () != null) {
						
						Cajero cajeroSeteado = (Cajero)cajaASetear.getCajeroAcargo ();
						Console.WriteLine ("La caja "+cajaASetear.getCodigoCaja().ToString() + " ya esta siendo atendida por " +  cajeroSeteado.getNombre() + " " + cajeroSeteado.getApellido() );
						Console.WriteLine ("Presione alguna tecla para volver...");
						Console.ReadKey ();
						}else{
						foreach (Cajero cajeroFiltro in listaCajeros) {
							if (cajeroFiltro.getCodigoCajero () == codigoCajero) {
								cajaASetear.setCajeroAcargo (cajeroFiltro);
								cajaASetear.setEstado (true);
							}
						}
					}


					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 3:
					Console.Clear ();
					Console.WriteLine ("C A J A S [Cerrar-caja]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese el número de la caja a cerrar [del 1 al 5]:");
					CodCaja = Console.ReadLine ();
					CodigoCaja = int.Parse (CodCaja);

					foreach (Caja caja in listaCajas) {
						if (caja.getCodigoCaja () == CodigoCaja) {
							caja.setEstado (false);
							caja.setCajeroAcargo (null);
						}
					}

					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);

					break;

				case 4:

					Console.Clear ();
					Console.WriteLine ("C A J A S [lista-cajas]");
					Console.WriteLine ("");
					foreach (Caja caj in listaCajas) {
						Console.WriteLine (caj.verCaja());
					}
					Console.WriteLine ("");
					Console.WriteLine ("Presione alguna tecla para volver...");
					Console.ReadLine ();

					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				
				default:
					Console.Clear();
					Console.WriteLine ("C A J A S");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número:");
					Console.WriteLine ("1 --> Nuevo cajero");
					Console.WriteLine ("2 --> Abrir caja");
					Console.WriteLine ("3 --> Cerrar caja");
					Console.WriteLine ("4 --> Listado de cajas");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					Console.WriteLine ("El número ingresado no es valido, vuelva a ingresar:");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				}	
			}
			Console.Clear ();
			//pasa parametros a la funcion volverSupermercado
			this.volverSupermercado (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
		}

		//volver al menu principal con las listas cargadas
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros, ArrayList listaClientes)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
			super.iniciar ();
		}
	}
}

