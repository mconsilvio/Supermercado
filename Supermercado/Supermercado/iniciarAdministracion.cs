using System;
using System.Collections;

//Menu Administracion
namespace Supermercado
{
	public class iniciarAdministracion
	{
		//creo la funcion con los parametros que recibe de los otros menues
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros, ArrayList listaClientes)
		{
			Console.WriteLine ("A D M I N I S T R A C I O N");
			Console.WriteLine ("");
			Console.WriteLine ("Ingrese un número:");
			Console.WriteLine ("1 --> Total recaudado");
			Console.WriteLine ("2 --> Total recaudado por caja");
			Console.WriteLine ("3 --> Total recaudado por cajero");
			Console.WriteLine ("4 --> Total recaudado por cliente");
			Console.WriteLine ("5 --> Volver al menu principal");
			Console.WriteLine ("");
			string ac = Console.ReadLine();
			try{
			long accion = long.Parse (ac);

			while (accion != 5)
			{
				switch (accion){
				case 1:
					Console.Clear ();
					Console.WriteLine ("A D M I N I S T R A C I O N [supermercado-total]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");

					//muestra el total reacudado por el supermercado
					double sumaTotal = 0.0;
					foreach (Caja cadaCaja in listaCajas) {
						sumaTotal += cadaCaja.getRecaudacion();
					}
					Console.WriteLine ( "Total reacudado por el supermercado: " + sumaTotal);
					Console.WriteLine ("");
					Console.WriteLine ("Presione una tecla para volver");
					Console.ReadKey ();

					Console.Clear();
					Console.WriteLine ("A D M I N I S T R A C I O N");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 2:
					Console.Clear ();
					Console.WriteLine ("A D M I N I S T R A C I O N [caja-total]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");

					Console.WriteLine ("Total reacudado por cada caja:");
					Console.WriteLine ("");
					//muestra el total reacudado por cada caja
					foreach (Caja cadaCaja in listaCajas) {
						Console.WriteLine ( "Caja Nº" + cadaCaja.getCodigoCaja () + ": $" + cadaCaja.getRecaudacion());
					}
					Console.WriteLine ("");
					Console.WriteLine ("Presione una tecla para volver");
					Console.ReadKey ();

					Console.Clear();
					Console.WriteLine ("A D M I N I S T R A C I O N");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 3:
					Console.Clear ();
					Console.WriteLine ("A D M I N I S T R A C I O N [cajero-total]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");

					Console.WriteLine ("Total reacudado por cada cajero:");
					Console.WriteLine ("");
					//muestra el total reacudado por cada cajero
					foreach (Cajero cadaCajero in listaCajeros) {
						Console.WriteLine (cadaCajero.getNombre () + cadaCajero.getApellido () + ": $" + cadaCajero.getRecaudacion());
					}
					Console.WriteLine ("");
					Console.WriteLine ("Presione una tecla para volver");
					Console.ReadKey ();

					Console.Clear();
					Console.WriteLine ("A D M I N I S T R A C I O N");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;

				case 4:

					Console.Clear ();
					Console.WriteLine ("A D M I N I S T R A C I O N [cliente-total]");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					Console.WriteLine ("Total reacudado por cada cliente:");
					Console.WriteLine ("");
					//muestra el total reacudado por cada cliente
					foreach (Cliente cadaCliente in listaClientes) {
						Console.WriteLine (cadaCliente.getNombre () + cadaCliente.getApellido () + ": $" + cadaCliente.getRecaudacion());
					}
					Console.WriteLine ("");
					Console.WriteLine ("Presione una tecla para volver");
					Console.ReadKey ();

					Console.Clear();
					Console.WriteLine ("A D M I N I S T R A C I O N");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese un número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				
				default:
					Console.Clear();
					Console.WriteLine ("A D M I N I S T R A C I O N");
					Console.WriteLine ("");
					Console.WriteLine ("Ingrese otro número:");
					Console.WriteLine ("1 --> Total recaudado");
					Console.WriteLine ("2 --> Total recaudado por caja");
					Console.WriteLine ("3 --> Total recaudado por cajero");
					Console.WriteLine ("4 --> Total recaudado por cliente");
					Console.WriteLine ("5 --> Volver al menu principal");
					Console.WriteLine ("");
					Console.WriteLine ("El número ingresado no es valido, vuelva a ingresar:");
					ac = Console.ReadLine();
					accion = long.Parse (ac);
					break;
				}	
			}
			}catch{
				Console.Clear ();
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("Ha ingresado carácteres no válidos vuelva a intentarlo");
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("");

				this.iniciar (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);

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