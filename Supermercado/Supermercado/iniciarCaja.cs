using System;
using System.Collections;


namespace Supermercado
{
	public class iniciarCaja
	{
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros)
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
			int accion = int.Parse (ac);

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
					string d = Console.ReadLine ();
					int dni = int.Parse (d);
					Console.Write ("Ingrese el horario de trabajo: ");
					string horario = Console.ReadLine ();
					int cantidadCajeros = listaCajeros.Count;
					Cajero cajero = new Cajero ();
					cajero.setCodigoCajero (cantidadCajeros);
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

					ac = Console.ReadLine();rew34
					accion = int.Parse (ac);

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
					foreach (Cajero cajero1 in listaCajeros){
						Console.WriteLine("Nº"+cajero1.getCodigoCajero()+" "+cajero1.getApellido()+", "+cajero1.getNombre()+".");
					}
					Console.WriteLine ("");
					string CajeroAcargo = Console.ReadLine ();
					int codigoCajero = int.Parse (CajeroAcargo);

					Caja caja = new Caja (CodigoCaja);
					caja.setEstado (true);

					foreach (Cajero cajeroFiltro in listaCajeros){
						if(cajeroFiltro.getCodigoCajero() == codigoCajero){
							caja.setCajeroAcargo (cajeroFiltro);
						}
					}
					listaCajas.Add (caja);

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
					accion = int.Parse (ac);

					break;

				case 3:
					Console.Clear ();
					Console.WriteLine ("C A J A S [Cerrar-caja]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese el número de la caja a cerrar [del 1 al 5]:");
					CodCaja = Console.ReadLine ();
					CodigoCaja = int.Parse (CodCaja);


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
					accion = int.Parse (ac);

					break;

				case 4:

					Console.Clear ();
					Console.WriteLine ("C A J A S [lista-cajas]");
					Console.WriteLine ("");
					foreach (Caja caj in listaCajas) {
						Console.WriteLine ((string)caj.verCaja ());
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
					accion = int.Parse (ac);
					break;
				
				default:
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
					accion = int.Parse (ac);
					break;
				}	
			}
			Console.Clear ();
			this.volverSupermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
		}
	}
}

