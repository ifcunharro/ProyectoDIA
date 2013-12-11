﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
		/// 
		public static AnadirModificarPersonajesForm anPers;
		public static EscenasForm esc;
		public static LibroAbiertoForm libA;
		public static ModificarCapituloForm modCap;
		public static NuevoCapituloForm nuevoCap;
		public static NuevoLibroForm nuevoLib;
		public static ReferencesForm references;
		public static ProcesadorTextos procesador;

		public static Libro Book;
		public static XMLPersistencia persistencia;
		public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			persistencia = new XMLPersistencia("plantilla.xml");
			Program.Book = persistencia.Leer();

			Program.libA = new LibroAbiertoForm();
			Program.libA.button1.Enabled=false;
			Program.libA.button2.Enabled=false;
			Program.libA.button3.Enabled=false;
			Program.libA.referenciasToolStripMenuItem.Enabled=false;
			Application.Run(Program.libA); // Libro sin Abrir
            
        }
    }
}