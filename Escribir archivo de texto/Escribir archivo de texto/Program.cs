using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Escribir_archivo_de_texto
{
    class Program
    {
        public SqlConnection con = new SqlConnection();
        static void Main(string[] args)
        {
            /***************************************************************************
             
             *  Para que esta app pueda funcionar devera de:
             *  
             *      Crear la db con una estructura => 
             *          -Nombre: Empresa, 
             *          -Tabla: Nomina, 
             *          -Atributos: Cedula, Nombre, Cuenta y Monto.
             *          
             *              _____________
             *              |  NOMINA   |
             *              |-----------|
             *              |  Cedula   |
             *              |  Nombre   |
             *              |  Cuenta   |
             *              |  Monto    |
             *              -------------
             * 
             *      Cambiar el driver de coneccion (password, userID, Ubicacion).
             *      De ser necesario la ubicacion de donde se esta guardando el archivo de texto.
             *      
             *  Funcionalidad o proposito de la app:
             *  
             *      Leer una Base de datos.
             *      Generar archivo de texto con los datos leido.
             *      
             *  Comentario:
             *      ...
             *      
             ***************************************************************************/
            //Conectamo a la db
            SqlConnection con = new SqlConnection("Data Source=FRANKSOFT;Initial Catalog=Empresa;Integrated Security=True");
            con.Open();//Abrimos conexion
            string textoCmd = "Select * from Nomina";//Creamos la consulta a DB
            SqlCommand cmd = new SqlCommand(textoCmd, con);//Ejecutamos la consulta
            SqlDataReader leer = cmd.ExecuteReader();//Leemos los valores que retornan
            string[] lines = new string[1000];//Creamos array para recivir los valores
            string Cedula;
            string Nombre;
            string Cuenta;
            string Monto;
            string concatenar;
            int conter = 0;
            while (leer.Read())
            {//Pasamos los datos obtenidos a el array
                Cedula = String.Format("{0}", leer[0]);
                Nombre = String.Format("{0}", leer[1]);
                Cuenta = String.Format("{0}", leer[2]);
                Monto = String.Format("{0}", leer[3]);
                concatenar = Cedula + "," + Nombre + "," + Cuenta + "," + Monto;
                lines[conter] = concatenar;
                conter++;

            }
            System.IO.File.WriteAllLines(@"D:\Nomina.txt", lines);//Generamos y guardamos archivo de texto.
            con.Close();//Cerramos conexion a db.
            Console.Write("Wiiiiii. Se ha generado el archivo de texto :p. \nOshe que rico!!! :V");
            System.Console.ReadKey();
        }
    }
}
