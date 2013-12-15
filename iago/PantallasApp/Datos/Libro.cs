using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	/// <summary>
	/// Un libro.
	/// </summary>
	public class Libro
	{
		/// <summary>
		/// Propiedad que define los Gets y Sets del titulo de <see cref="Scrivener.Libro">.
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
		/// Propiedad que define los Gets y Sets de una anotacion de <see cref="Scrivener.Libro">.
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
		/// Gets or sets de capitulos.
		/// </summary>
		/// <value>
		/// LinkedList de Capitulos.
		/// </value>
		public LinkedList<Capitulo> Capitulos
		{
			get;
			set;
		}

		/// <summary>
		/// Propiedad que define los Gets y Sets de los actores de <see cref="Scrivener.Libro">.
		/// </summary>
		/// <value>
		/// Los actores
		/// </value>
        public Actores Actores
        {
                    get;set;
        }
		
		public List<Referencia> Referencias{
			get;
			set;
		}	
		
		/// <summary>
		/// Crea un nuevo <see cref="Scrivener.Libro"/> vacio.
		/// </summary>
		public Libro ()
		{
			this.Capitulos = new LinkedList<Capitulo>();
			this.Referencias = new List<Referencia>();
			this.Anotacion = "";
			this.Titulo="";
            this.Actores = new Actores();
		}
		
		/// <summary>
		/// Crea un nuevo <see cref="Scrivener.Libro"/>.
		/// </summary>
		/// <param name='titulo'>
		/// Titulo.
		/// </param>
		public Libro ( String titulo)
		{
			this.Capitulos = new LinkedList<Capitulo>();
			this.Anotacion = "";
			this.Titulo=titulo;
			this.Referencias = new List<Referencia>(); 
            this.Actores = new Actores();
		}
		
		/// <summary>
		/// Crea un nuevo <see cref="Scrivener.Libro"/>.
		/// </summary>
		/// <param name='titulo'>
		/// Titulo.
		/// </param>
		/// <param name='anotacion'>
		/// Anotacion.
		/// </param>
		/// <param name='capitulos'>
		/// Capitulos.
		/// </param>
		/// <param name='actores'>
		/// Actores.
		/// </param>
		public Libro ( String titulo, String anotacion, LinkedList<Capitulo> capitulos,Actores actores, List<Referencia> referencias)     
		{
			Titulo = titulo;
			Anotacion = anotacion;			
			this.Capitulos = capitulos;
            this.Actores = actores;
			this.Referencias = referencias;
		}
		
		/// <summary>
		/// Crear un nuevo capitulo.
		/// </summary>
		/// <param name='titulo'>
		/// Titulo.
		/// </param>
		/// <param name='anotacion'>
		/// Anotacion.
		/// </param>
		public void CrearCapitulo(String titulo, String anotacion)
		{
			this.Capitulos.AddLast(new Capitulo(titulo, anotacion));
		}
		
		/// <summary>
		/// Buscar el capitulo especificado.
		/// </summary>
		/// <returns>
		/// El capitulo encontrado.
		/// </returns>
		/// <param name='titulo'>
		/// Titulo del capitulo que se busca.
		/// </param>
		public Capitulo BuscarCapitulo(String titulo)
		{
				foreach(var i in this.Capitulos)
				{
					if (titulo.Equals(i.Titulo))
					return i;
				}
			// Aqui falta cambiar este bloque para que lance una excepcion si no encuentra el libro
		    var toret = new Capitulo();
			return(toret);
		}

		public Capitulo BuscarCapituloId(String id)
		{
				foreach(var i in this.Capitulos)
				{
					if (id.Equals(i.Id))
						return i;
				}
			return null;
		}
		public Escena BuscarEscenaId(String id)
		{
				foreach(var i in this.Capitulos)
				{
					Escena aux = i.BuscarEscenaId(id);
					if(aux!=null){
						return aux;
					}
						
				}
			return null;
		}
        
        //puesto este metodo recientemente
        public Actor BuscarPersonajeId(String id)
        {
            foreach (var i in this.Actores)
            {
                if (id.Equals(i.Id))
                    return i;
            }
            return null;
        }
	}
}
