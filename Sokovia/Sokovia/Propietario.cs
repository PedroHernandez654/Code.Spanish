using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokovia
{
    class Propietario
    {
        private string TipoPropietario, Nombre, Apellidos, TipoLicencia, Genero;
        private int id_propietario, edad,CantidadV;
        private List<Propietario> GeneroHM;
        private List<Propietario> LISTA;
 

        public string TipoPropietario1 { get => TipoPropietario; set => TipoPropietario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string TipoLicencia1 { get => TipoLicencia; set => TipoLicencia = value; }
        public int Id_propietario { get => Id_propietario1; set => Id_propietario1 = value; }
        public int Edad { get => edad; set => edad = value; }
        
        public string NombreCompleto { get => $"{Nombre}{Apellidos}"; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public int Id_propietario1 { get => id_propietario; set => id_propietario = value; }
        public int CantidadV1 { get => CantidadV; set => CantidadV = value; }
        internal List<Propietario> GeneroHM1 { get => GeneroHM; set => GeneroHM = value; }
        internal List<Propietario> LISTA1 { get => LISTA; set => LISTA = value; }

        public void mostrarDatosPro()
        {
            Console.WriteLine("Estos son los datos del Propietario");
            Console.WriteLine();
            Console.WriteLine($"ID del Propietario:{Id_propietario}");
            Console.WriteLine($"Nombre Completo: {NombreCompleto}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Tipo de licencia: {TipoLicencia}");
        }
        
            
            /*int numgen = 0;
            foreach(Propietario i in genw)
            {
                numgen += i.genw.Count;
            }
            Console.WriteLine($"Genero:{numgen}");*/
            /*if(Genero == "Hombre")
            {
                GeneroHM.Add(Genero);
            }
            else if (Genero == "Mujer")
            {
                GenreHM.Add(Genero);
            }
            Console.WriteLine("Masculino" + countH);
            Console.WriteLine("Femenino" + countM);*/
        
    }
}
