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

			//instancia la clase Supermecado y pasa las listas como parametros al constructor
			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}
	}
}