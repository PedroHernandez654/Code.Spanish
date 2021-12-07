using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokovia
{
    class Vehiculo
    {
        private string TipoVehiculo, MarcaVehiculo, Modelo, Placa;
        private int  capacidad;
        private Propietario propietario;
        private List<Vehiculo> Veh;
        private List<Vehiculo> VEHI;


        public string TipoVehiculo1 { get => TipoVehiculo; set => TipoVehiculo = value; }
        public string MarcaVehiculo1 { get => MarcaVehiculo; set => MarcaVehiculo = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public int Capacidad1 { get => capacidad; set => capacidad = value; }
        internal Propietario Propietario { get => propietario; set => propietario = value; }
        internal List<Vehiculo> Veh1 { get => Veh; set => Veh = value; }
        internal List<Vehiculo> VEHI1 { get => VEHI; set => VEHI = value; }

        public void mostrar()
        {
            Console.WriteLine("Estos son los datos del vehículo");
            Console.WriteLine();
            Console.WriteLine($"Tipo de Vehículo: {TipoVehiculo}");
            Console.WriteLine($"Marca del Vehículo: {MarcaVehiculo}");
            Console.WriteLine($"Modelo del Vehículo: {Modelo}");
            Console.WriteLine($"Capacidad del Vehículo: {capacidad}");
            Console.WriteLine($"Placa: {Placa}");
        }
        public void mostrar_Propietario()
        {
            Propietario.mostrarDatosPro();
        }

    }
}
