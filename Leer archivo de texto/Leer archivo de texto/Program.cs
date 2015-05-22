using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Leer_archivo_de_texto
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
             *          -Nombre: Banco, 
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
             *      Leer un archivo de texto ya generado por otra aplicacion.
             *      Insertar campos en la base de datos.
             *      
             *  Comentario:
             *      ...
             *      
             ***************************************************************************/


            //Conectamo a la db
            SqlConnection con = new SqlConnection("Data Source=FRANKSOFT;Initial Catalog=Banco;Integrated Security=True");
            string[] Empleados = System.IO.File.ReadAllLines(@"D:\Nomina.txt");//Bucamos la direccion del archivo
            string[] InsEmpleado;//obtendra los datos del archivo.
            foreach (string empleado in Empleados)
            {//Recorremos todas las lineas del archivo
                InsEmpleado = empleado.Split(new Char[] {','});//Separamos los datos en un array
                if (!String.IsNullOrEmpty(InsEmpleado[0]))
                {//verificamos que la cadena que este pasando no este vacia 
                    con.Open();//Abrimos conexion
                    //Creamos el script
                    string textoCmd = "INSERT INTO Nomina VALUES ('" + InsEmpleado[0] + "','" + InsEmpleado[1] + "','" + InsEmpleado[2] + "','" + InsEmpleado[3] + "')";//Creamos la consulta a DB
                    SqlCommand cmd = new SqlCommand(textoCmd, con);//Ejecutamos la consulta
                    cmd.ExecuteReader();
                    con.Close();//Cerramos conexion 
                }
            }
            Console.Write("\nEsto Fue todo amigo, hehehe hehehe hehehehhehehe.");
            System.Console.ReadKey();
        }
    }
}
