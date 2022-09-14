using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U3_A3_JHRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            //Prueba de conexión
            Conexion q1 = new Conexion();
            q1.conectar();
            q1.desconectar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                //Validación de campo especie
                if (cmpEspecie.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar una especie");
                }
                else if (cmpEspecie.Text.Trim().Length < 5 )
                {
                    MessageBox.Show("Debe ingresar un nombre de especie de al menos 5 letras");
                }

                //Validación de campo cantidad
                if (cmpCantidad.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar una cantidad");
                }
                else if (cmpCantidad.Text.Trim().All(Char.IsNumber) == false)
                {
                    MessageBox.Show("Debe ingresar un número entero");
                }

                else
                {
                    Planta p = new Planta();
                    p.Especie = cmpEspecie.Text.Trim().ToLower();
                    p.Fecha = cmpFecha.Text.Trim().ToLower();
                    p.Cantidad = Convert.ToInt32(cmpCantidad.Text);

                    if (AccesoDatosPlanta.guardar(p))
                    {
                        MessageBox.Show("El registro se guardó correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Registro no se pudo guardar");
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
