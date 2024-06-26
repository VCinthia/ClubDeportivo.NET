using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace club_deportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicio());
            //Application.Run(new FormNuevoCliente());


            // Crear una instancia de Conexion
            var conexion = Datos.Conexion.getInstancia();

            // Intentar crear una conexión
            using (var dbConnection = conexion.CrearConexion())
            {
                // La conexión se imprimirá en la consola según la lógica en Conexion.cs
            }
        }
    }
}

