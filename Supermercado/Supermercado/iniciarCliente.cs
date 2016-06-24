using System;
using System.Collections;

//Menu Clientes
namespace Supermercado
{
	public class iniciarCliente
	{
		//creo la funcion con los parametros que recibe de los otros menues
		public void iniciar(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros,ArrayList listaClientes)
		{
			Console.WriteLine ("P R O D U C T O S [Compra-productos]");
			Console.WriteLine ("");
			Console.WriteLine ("Listado de productos: ");
			//lista los productos numerados 
			int i = 1;
			foreach (Producto cadaProducto in listaProductos) {
				Console.WriteLine (i + "--> " + cadaProducto.mostrarProducto ());
				i++;	
			}

			Console.WriteLine ("");
			Console.WriteLine ("----------------------------------------");
			Console.WriteLine ("Productos en el carrito");
			Console.WriteLine ("----------------------------------------");
			//crea un carrito
			Carrito carrito = new Carrito ();
			//si el objecto carrito tiene productos, llama a la funcion mostrarProdDelCarrito
			if (carrito.productosEnCarrito != null){
				carrito.mostrarProdDelCarrito ();
			}
			Console.WriteLine ("");
			Console.WriteLine ("Agregue un producto al carro o 0 para finalizar");
			string aPr= Console.ReadLine ();
			int agregarProducto = int.Parse (aPr);

			while (agregarProducto != 0){
				//obtiene el producto seleccionado en la posicion que selecciona el usuario
				Producto prodSeleccionado = (Producto)listaProductos [agregarProducto - 1];

				Console.WriteLine ("");
				Console.WriteLine ("¿Cuantas unidades desea agregar?");
				string cAg= Console.ReadLine ();
				int cantAgregar = int.Parse (cAg);
				//el objeto carrito llama a la funcion agregar y carga el producto mas la cantidad
				carrito.agregarProducto (prodSeleccionado,cantAgregar);

				Console.Clear ();
				Console.WriteLine ("P R O D U C T O S [Compra-productos]");
				Console.WriteLine ("");
				Console.WriteLine ("Listado de productos: ");

				//lista los productos numerados 
				i = 1;
				foreach (Producto cadaProducto in listaProductos) {
					Console.WriteLine (i + "--> " + cadaProducto.mostrarProducto ());
					i++;	
				}

				Console.WriteLine ("");
				Console.WriteLine ("----------------------------------------");
				Console.WriteLine ("Productos en el carrito");
				Console.WriteLine ("----------------------------------------");

				//si el objecto carrito tiene productos, llama a la funcion mostrarProdDelCarrito
				if (carrito.productosEnCarrito != null){
					carrito.mostrarProdDelCarrito ();
				}
				Console.WriteLine ("----------------------------------------");
				Console.WriteLine ("");
				Console.WriteLine ("Agregue un producto al carro o 0 para finalizar");
				aPr= Console.ReadLine ();
				agregarProducto = int.Parse (aPr);
			}

			Console.Clear ();
			Console.WriteLine ("P R O D U C T O S [Compra-productos]");
			Console.WriteLine ("");
			Console.WriteLine ("----------------------------------------");
			Console.WriteLine ("Productos en el carrito");
			Console.WriteLine ("----------------------------------------");
			//si el objecto carrito tiene productos, llama a la funcion mostrarProdDelCarrito
			if (carrito.productosEnCarrito != null){
				carrito.mostrarProdDelCarrito ();
			}

			Console.WriteLine ("");
			Console.WriteLine ("----------------------------------------");
			Console.WriteLine ("Cajas abiertas");
			Console.WriteLine ("----------------------------------------");
			//muestra la listas de las cajas y su estado
			foreach (Caja caj in listaCajas) {
				if (caj.getEstado() == true) {
					Console.WriteLine (caj.verCaja ());
				}
			}
			Console.WriteLine ("");
			Console.WriteLine ("¿En que caja desea pagar?");
			string cAP = Console.ReadLine ();
			int cajaAPagar = int.Parse (cAP);

			//obtiene la caja seleccionado en la posicion que selecciona el usuario
			Caja cajaSeleccionada = (Caja)listaCajas [cajaAPagar - 1];
			Console.WriteLine (cajaSeleccionada.getCajeroAcargo ().getNombre ());
			//suma el monto pasado por parametro a la recaudacion de la caja seleccionada
			//cajaSeleccionada.agregarRecaudacion (monto);

			Console.WriteLine ("");
			Console.WriteLine ("Nueva Compra");
			Console.WriteLine ("Ingrese el DNI del cliente:");
			string dni= Console.ReadLine ();
			bool existe = false;

			foreach (Cliente cliente in listaClientes){
				if (cliente.getDni() == dni) {
					Console.WriteLine(cliente.mostrarCliente());
					Console.ReadKey ();
					existe = true;
				}
			}
			if (existe == false) {
				Console.WriteLine ("El cliente no existe, por favor cargelo:");
				Console.Write ("");
				Console.Write ("Ingrese el nombre: ");
				string nombre = Console.ReadLine ();
				Console.Write ("Ingrese el apellido: ");
				string apellido = Console.ReadLine ();
				Console.Write ("Ingrese el dni: ");
				dni = Console.ReadLine ();
				Console.Write ("Ingrese la fecha de nacimiento: ");
				string nacimiento = Console.ReadLine ();

				//crea un cliente, los setea y lo agrega a listaClientes
				Cliente client = new Cliente ();
				client.setNombre (nombre);
				client.setApellido (apellido);
				client.setDni (dni);
				client.setNacimiento (nacimiento);
				listaClientes.Add (client);
				Console.ReadKey ();
			}

			//trae los valores que me devuelve la funcion calcularPromo
			ArrayList pagoYAhorro = carrito.calcularPromo (listaPromociones);
			double pagar = (double)pagoYAhorro [0];
			double ahorro = (double)pagoYAhorro [1];

			Console.WriteLine ("Total a pagar:" + pagar.ToString());
			Console.WriteLine ("Con su compra ahorró:" + ahorro.ToString());
			Console.WriteLine ("");
			Console.WriteLine ("Precione una tecla para volver");
			Console.ReadKey ();

			//suma el total a la recaudacion que tenia
			cajaSeleccionada.agregarRecaudacion (pagar);

			//crea la variable cajero le asigna el cajero y luego le suma el monto
			Cajero cajero = cajaSeleccionada.getCajeroAcargo ();
			cajero.agregarRecaudacion(pagar);

			//busca el cliente, cuando lo encuentra a ese le setea la recaudacion
			foreach (Cliente cliente in listaClientes){
				if (cliente.getDni() == dni) {
					cliente.agregarRecaudacion(pagar);
				}
			}

			//pasa parametros a la funcion volverSupermercado
			this.volverSupermercado (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
		}

		//volver al menu principal con las listas cargadas
		public void volverSupermercado (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros,ArrayList listaClientes)
		{
			Console.Clear ();
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
			super.iniciar ();
		}
	}
}