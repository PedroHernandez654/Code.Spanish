using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Parcial
{
    public class Conductor
    {
        int id_conductor;
        int id_tipo,no_licencia;
        string Usuario, Password, Conpassword, nombre, apellido_p, apellido_m, telefono;

        public int Id_conductor { get => id_conductor; set => id_conductor = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int No_licencia { get => no_licencia; set => no_licencia = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Conpassword1 { get => Conpassword; set => Conpassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
