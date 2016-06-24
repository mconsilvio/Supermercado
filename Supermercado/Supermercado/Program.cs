using System;
using System.Collections;

//inicio de programa
namespace Supermercado
{
	public class MainClass
	{
		public static void Main (string[] args)
		{	
			//Crear nuevas listas vacias
			ArrayList listaProductos = new ArrayList();
			ArrayList listaPromociones = new ArrayList ();
			ArrayList listaCajas = new ArrayList();
			ArrayList listaCajeros = new ArrayList ();
			ArrayList listaClientes = new ArrayList ();

			//instancio la funcion que trae las listas precargada
			preCarga pre = new preCarga ();
			//funcion que trae las cajas
			pre.preCargaCajas (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
			//funcion que trae las productos
			pre.preCargaProductos (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
			//funcion que trae los cajeros
			pre.preCargaClientes (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);

			//instancia la clase Supermecado y pasa las listas como parametros al constructor
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros, listaClientes);
			super.iniciar ();
		}
	}
}