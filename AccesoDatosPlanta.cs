using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DPRN3_U3_A3_JHRM
{
    class AccesoDatosPlanta
    {
        public static bool guardar(Planta p)
        {
            try
            {
                Conexion con = new Conexion();

                //Sentencia SQL insert
                string sql = "INSERT INTO Planta (especie, fecha, cantidad)" +
                    "VALUES ('" + p.Especie +
                    "','" + p.Fecha +
                    "','" + p.Cantidad +
                    "')";



                SqlCommand cmd = new SqlCommand(sql, con.conectar());

                //Cantidad de filas modificadas
                int cantidadFilas = cmd.ExecuteNonQuery();
                //se desconecta la bd después de insertar
                con.desconectar();

                //Si se guardó correctamente
                if (cantidadFilas == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
    }

}
