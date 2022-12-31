using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Parcial
{
    public class vehiculo
    {
        int id_vehiculo, No_viajes, id_conductor;
        string placas, tipo, marca, modelo;

        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public int No_viajes1 { get => No_viajes; set => No_viajes = value; }
        public int Id_conductor { get => id_conductor; set => id_conductor = value; }
        public string Placas { get => placas; set => placas = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
