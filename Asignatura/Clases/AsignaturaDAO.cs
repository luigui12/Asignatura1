using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Academico
{
    public static class AsignaturaDAO
    {
        public static String cadenaConexion = @"server=LABORATORIO2\SQLEXPRESS2016; database=TI2019; user id=sa; password=lab123456;";

        public static int guardar(Asignatura asignatura){

            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "insert into Asignatura(codAsignatura,nombreAsignatura,nivel,creditos,carrera) " +
                " values(@codAsignatura,@nombreAsignatura,@nivel,@creditos,@carrera) ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignatura.codAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignatura.nombre);
            comando.Parameters.AddWithValue("@nivel", asignatura.nivel);
            comando.Parameters.AddWithValue("@creditos", asignatura.creditos);
            comando.Parameters.AddWithValue("@carrera", asignatura.carrera);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }

        public static DataTable getDatos(){

            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura,nombreAsignatura,nivel,creditos,carrera " +
                " from Asignatura order by carrera";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static int actualizar(Asignatura asignatura)
        {
            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "UPDATE Asignatura SET nombreAsignatura=@nombreAsignatura,nivel=@nivel,creditos=@creditos," +
                "carrera=@carrera WHERE codAsignatura=@codAsignatura";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignatura.codAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignatura.nombre);
            comando.Parameters.AddWithValue("@nivel", asignatura.nivel);
            comando.Parameters.AddWithValue("@creditos", asignatura.creditos);
            comando.Parameters.AddWithValue("@carrera", asignatura.carrera);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }

        public static int eliminar(string asignatura){

            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "delete from Asignatura where codAsignatura=@codAsignatura";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignatura);

            //abrimos conexion
            conn.Open();

            //ejecutamos el comando
            int x = comando.ExecuteNonQuery();

            //cerrmos conexion
            conn.Close();

            return x;
        }
    }
}
