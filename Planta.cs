using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN3_U3_A3_JHRM
{
    class Planta
    {
        //Atributos de cada planta
        private string especie;
        private string fecha;
        private int cantidad;

        //Constructores se inicializan vacios o en 0
        public Planta()
        {
            this.especie = "";
            this.fecha = "";
            this.cantidad = 0;
        }

        //Métodos Get Set para acceder y modificar datos
        public string Especie { get => especie; set => especie = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
