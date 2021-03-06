using System;
using System.Collections.Generic;

namespace Scrivener
{
	/// <summary>
	/// Un capitulo.
	/// </summary>
	public class Capitulo
	{
		/// <summary>
		/// Lista de escenas de las que se compone.
		/// </summary>
		public LinkedList<Escena> escenas;
		
		/// <summary>
		/// Inicializa un <see cref="Scrivener.Capitulo"/> vacio.
		/// </summary>
		public Capitulo ()
		{
			DateTime start = new DateTime(1995, 1, 1);
		    Random gen = new Random();
		    int range = (DateTime.Today - start).Days;       
			this.Id = start.AddDays(gen.Next(range)).ToString("yyyyMMddHHmmssffff");
			
			this.Escenas=new LinkedList<Escena>();
			this.Titulo="";
			this.Anotacion="";
		}
		
		/// <summary>
		/// Crea un nuevo <see cref="Scrivener.Capitulo"/>.
		/// </summary>
		/// <param name='titulo'>
		/// Titulo.
		/// </param>
		/// <param name='anotacion'>
		/// Anotacion.
		/// </param>
		public Capitulo (String titulo, String anotacion)
		{
			DateTime start = new DateTime(1995, 1, 1);
		    Random gen = new Random();
		    int range = (DateTime.Today - start).Days;       
			this.Id = start.AddDays(gen.Next(range)).ToString("yyyyMMddHHmmssffff");
			
			Titulo = titulo;
			Anotacion = anotacion;
			this.Escenas = new LinkedList<Escena>();
		}
		
		/// <summary>
		/// Modificar el capitulo.
		/// </summary>
		/// <param name='titulo'>
		/// Titulo.
		/// </param>
		/// <param name='anotacion'>
		/// Anotacion.
		/// </param>
		public void ModificarCapitulo (String titulo, String anotacion)
		{		
			this.Titulo = titulo;
			this.Anotacion = anotacion;
		}
		
		/// <summary>
		/// Crear una escena nueva.
		/// </summary>
		/// <param name='tituloe'>
		/// Titulo.
		/// </param>
		/// <param name='anotacione'>
		/// Anotacion.
		/// </param>
		/// <param name='contenidoe'>
		/// Contenido.
		/// </param>
		public void CrearEscena(string tituloe, string anotacione ,string contenidoe){
			Escenas.AddLast(new Escena(tituloe, anotacione , contenidoe));
		}
		
		public Escena BuscarEscena(String titulo)
		{
				foreach(var i in this.Escenas)
				{
					if (i.Titulo == titulo)
					return i;
				}
			// Aqui falta cambiar este bloque para que lance una excepcion si no encuentra el libro
		    var toret = new Escena();
			return(toret);
		}
		
		/// <summary>
		/// Gets y sets del identificador (ID).
		/// </summary>
		/// <value>
		/// El identificador.
		/// </value>
		public String Id
		{
			get;
			set;
		}
		
		/// <summary>
		/// Propiedad que define los Gets y Sets del titulo de <see cref="Scrivener.Capitulo"/>.
		/// </summary>
		/// <value>
		/// El titulo.
		/// </value>
		public String Titulo 
		{
			get;
			set;
		}
		
		/// <summary>
		/// Propiedad que define los Gets y Sets de una anotacion de <see cref="Scrivener.Capitulo"/>.
		/// </summary>
		/// <value>
		/// Una anotacion.
		/// </value>
		public String Anotacion 
		{
			get;
			set;
		}
		
		/// <summary>
		/// Gets y sets de escenas.
		/// </summary>
		/// <value>
		/// LinkedList que contiene las escenas.
		/// </value>
		public LinkedList<Escena> Escenas
		{
			get;
			set;
		}
	}
}


