using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokovia
{
    class Registro:Propietario
    {
        //Propietario Registrado
        private List<Propietario> PropietarioR;
        //Vehiculo Reistrado
        private List<Vehiculo> VehiculoR;

        internal List<Propietario> PropietarioR1 { get => PropietarioR; set => PropietarioR = value; }
        internal List<Vehiculo> VehiculoR1 { get => VehiculoR; set => VehiculoR = value; }

        public void Propietarios_Registrados()
        {
            foreach(Propietario PropTemp in PropietarioR)
            {
                Console.WriteLine("Propietarios Registrados");
                Console.WriteLine();
                Console.WriteLine($"ID: {PropTemp.Id_propietario}");
                Console.WriteLine($"Nombre: {PropTemp.NombreCompleto}");
                Console.WriteLine($"Tipo: {PropTemp.TipoPropietario1}");
                Console.WriteLine($"Licencia: {PropTemp.TipoLicencia1}");
            }
        }

        public void Vehiculos_Registrados()
        {
            foreach(Vehiculo VehTemp in VehiculoR)
            {
                Console.WriteLine("Vehiculos Registrados");
                Console.WriteLine();
                Console.WriteLine($"Placa: {VehTemp.Placa1}");
                Console.WriteLine($"Tipo de Vehiculo: {VehTemp.TipoVehiculo1}");
                Console.WriteLine($"Modelo: {VehTemp.Modelo1}");
                Console.WriteLine($"Marca: {VehTemp.MarcaVehiculo1}");
                Console.WriteLine($"Capacidad MAX pasajeros: {VehTemp.Capacidad1}");
            }
        }

    }
}
