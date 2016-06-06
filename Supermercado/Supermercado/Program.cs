using System;
using System.Collections;

namespace Supermercado
{
	public class MainClass
	{
		public static void Main (string[] args)
		{	
			ArrayList listaProductos = new ArrayList();
			ArrayList listaPromociones = new ArrayList ();
			ArrayList listaCajas = new ArrayList();
			ArrayList listaCajeros = new ArrayList ();

			Supermercado super = new Supermercado (listaProductos, listaPromociones, listaCajas, listaCajeros);
			super.iniciar ();
		}
	}
}