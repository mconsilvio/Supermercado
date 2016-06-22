using System;
using System.Collections;

//funcion de preCarga
namespace Supermercado
{
	public class preCarga
	{
		//precarga de las cajas
		public void preCargaCajas (ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros){

			//crea las cajas
			Caja caja1 = new Caja (1);
			Caja caja2 = new Caja (2);
			Caja caja3 = new Caja (3);
			Caja caja4 = new Caja (4);
			Caja caja5 = new Caja (5);

			//agrega las cajas a la listaCajas
			listaCajas.Add(caja1);
			listaCajas.Add(caja2);
			listaCajas.Add(caja3);
			listaCajas.Add(caja4);
			listaCajas.Add(caja5);

			//crea los cajeros
			Cajero cajero1 = new Cajero ();
			Cajero cajero2 = new Cajero ();

			//carga los datos de los cajeros
			cajero1.setCodigoCajero (1);
			cajero1.setNombre("Mariano");
			cajero1.setApellido ("Rojas");
			cajero1.setDni (35224926);
			cajero1.setHorario ("de 12 a 20");

			cajero2.setCodigoCajero (2);
			cajero2.setNombre("Matias");
			cajero2.setApellido ("Perez");
			cajero2.setDni (37138426);
			cajero2.setHorario ("de 8 a 14");

			//agrega los cajeros a la listaCajeros
			listaCajeros.Add (cajero1);
			listaCajeros.Add (cajero2);

			//carga cajeros a las cajas creadas y le cambio el estado a abierto
			caja1.setCajeroAcargo (cajero1);
			caja1.setEstado (true);
			caja3.setCajeroAcargo (cajero2);
			caja3.setEstado (true);
		}

		//precarga de productos
		public void preCargaProductos(ArrayList listaProductos,ArrayList listaPromociones,ArrayList listaCajas,ArrayList listaCajeros){
		
			//crea productos
			Producto producto1 = new Producto ();
			Producto producto2 = new Producto ();
			Producto producto3 = new Producto ();
			Producto producto4 = new Producto ();
			Producto producto5 = new Producto ();

			//carga los datos de los productos
			producto1.setTipo ("azucar");
			producto1.setMarca ("Domino"); 
			producto1.setEnvase("1 kg");
			producto1.setPrecio (10);

			producto2.setTipo ("yerba");
			producto2.setMarca ("Marolio");
			producto2.setEnvase("0,5 kg");
			producto2.setPrecio (25);

			producto3.setTipo ("Pasas de uva");
			producto3.setMarca ("Uvitech");
			producto3.setEnvase("0,25 gr");
			producto3.setPrecio (15);

			producto4.setTipo ("Gaseosa");
			producto4.setMarca ("Manaos");
			producto4.setEnvase("1,25 ltrs");
			producto4.setPrecio (20);

			producto5.setTipo ("Lustra Mueble");
			producto5.setMarca ("Blem");
			producto5.setEnvase("360 cm3");
			producto5.setPrecio (37.4);

			//agrega los productos a la listaProductos
			listaProductos.Add (producto1);
			listaProductos.Add (producto2);
			listaProductos.Add (producto3);
			listaProductos.Add (producto4);
			listaProductos.Add (producto5);

			//crea promociones
			Promocion promocion1 = new Promocion ();
			Promocion promocion2 = new Promocion ();
			Promocion promocion3 = new Promocion ();
			Promocion promocion4 = new Promocion ();
			Promocion promocion5 = new Promocion ();

			//carga los datos de las promociones
			promocion1.setProducto (producto1);
			promocion1.setCantidadLLevar (2); 
			promocion1.setCantidadPagar(1);

			promocion2.setProducto (producto2);
			promocion2.setCantidadLLevar (4);
			promocion2.setCantidadPagar(2);

			promocion3.setProducto (producto3);
			promocion3.setCantidadLLevar (5); 
			promocion3.setCantidadPagar(2);

			promocion4.setProducto (producto4);
			promocion4.setCantidadLLevar (3);
			promocion4.setCantidadPagar(1);

			promocion5.setProducto (producto5);
			promocion5.setCantidadLLevar (2);
			promocion5.setCantidadPagar(1);

			//agrega las promociones a la listaPromociones
			listaPromociones.Add (promocion1);
			listaPromociones.Add (promocion2);
			listaPromociones.Add (promocion3);
			listaPromociones.Add (promocion4);
			listaPromociones.Add (promocion5);
		}
	}
}

