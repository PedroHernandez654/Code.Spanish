using System;
using System.Collections.Generic;

namespace Sokovia
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Vehiculo> VehiculoTemp = new List<Vehiculo>();
            //List<Propietario> listaGen = new List<Propietario>();
            //PROPIETARIOS
            Propietario Propietario1 = new Propietario();
            Propietario1.Id_propietario = 123;
            Propietario1.Nombre1 = "Pedro";
            Propietario1.Apellidos1 = " Hernández Dzul";
            Propietario1.Edad = 19;
            Propietario1.Genero1 = "Hombre";
            Propietario1.TipoLicencia1 = "Tipo A(Sin fines de lucro)";
            Propietario1.TipoPropietario1 = "Ciudadano";

            Propietario Propietario2 = new Propietario();
            Propietario2.Id_propietario = 124;
            Propietario2.Nombre1 = "Juan";
            Propietario2.Apellidos1 = " Pérez Tuyu";
            Propietario2.Edad = 45;
            Propietario2.Genero1 = "Hombre";
            Propietario2.TipoLicencia1 = "Tipo B(Mar)";
            Propietario2.TipoPropietario1 = "Ciudadano";

            Propietario Propietario3 = new Propietario();
            Propietario3.Id_propietario = 125;
            Propietario3.Nombre1 = "Adrián";
            Propietario3.Apellidos1 = " Alpuche López";
            Propietario3.Edad = 29;
            Propietario3.Genero1 = "Hombre";
            Propietario3.TipoLicencia1 = "Tipo C(Empresa)";
            Propietario3.TipoPropietario1 = "Empresa Madera";
            Propietario3.CantidadV1 = 2;

            Propietario Propietario4 = new Propietario();
            Propietario4.Id_propietario = 126;
            Propietario4.Nombre1 = "Valentina";
            Propietario4.Apellidos1 = " Vázquez Luna";
            Propietario4.Edad = 18;
            Propietario4.Genero1 = "Mujer";
            Propietario4.TipoLicencia1 = "Tipo C(Empresa)";
            Propietario4.TipoPropietario1 = "Empresa Espacial";
            Propietario4.CantidadV1 = 4;
            //LISTA PPROPIETARIOS
            List<Propietario> Propietarios = new List<Propietario>();
            Propietarios.Add(Propietario1);
            Propietarios.Add(Propietario2);
            Propietarios.Add(Propietario3);
            Propietarios.Add(Propietario4);


            // VEHICULOS
            Vehiculo vehiculo1 = new Vehiculo();
            vehiculo1.Placa1 = "888-ABC";
            vehiculo1.Propietario = Propietario1;
            vehiculo1.Modelo1 = "Civic 2021";
            vehiculo1.MarcaVehiculo1 = "Honda";
            vehiculo1.TipoVehiculo1 = "Terrestre";
            vehiculo1.Capacidad1 = 5;

            Vehiculo vehiculo2 = new Vehiculo();
            vehiculo2.Placa1 = "789-GFD";
            vehiculo2.Propietario = Propietario2;
            vehiculo2.Modelo1 = "Bote Pesca";
            vehiculo2.MarcaVehiculo1 = "Budge";
            vehiculo2.TipoVehiculo1 = "Maritimo";
            vehiculo2.Capacidad1 = 4;

            Vehiculo vehiculo3 = new Vehiculo();
            vehiculo3.Placa1 = "258-OPI";
            vehiculo3.Propietario = Propietario3;
            vehiculo3.Modelo1 = "Avión 345";
            vehiculo3.MarcaVehiculo1 = "AeroNaves";
            vehiculo3.TipoVehiculo1 = "AeroNave";
            vehiculo3.Capacidad1 = 10;

            Vehiculo vehiculo4 = new Vehiculo();
            vehiculo4.Placa1 = "QWE-897";
            vehiculo4.Propietario = Propietario3;
            vehiculo4.Modelo1 = "Accord";
            vehiculo4.MarcaVehiculo1 = "Honda";
            vehiculo4.TipoVehiculo1 = "Terrestre";
            vehiculo4.Capacidad1 = 5;

            Vehiculo vehiculo5 = new Vehiculo();
            vehiculo5.Placa1 = "NAS-997";
            vehiculo5.Propietario = Propietario4;
            vehiculo5.Modelo1 = "12-NASA";
            vehiculo5.MarcaVehiculo1 = "NASA";
            vehiculo5.TipoVehiculo1 = "Espacial";
            vehiculo5.Capacidad1 = 3;

            Vehiculo vehiculo6 = new Vehiculo();
            vehiculo6.Placa1 = "GYA-325";
            vehiculo6.Propietario = Propietario4;
            vehiculo6.Modelo1 = "Yaris";
            vehiculo6.MarcaVehiculo1 = "Toyota";
            vehiculo6.TipoVehiculo1 = "Terrestre";
            vehiculo6.Capacidad1 = 5;

            Vehiculo vehiculo7 = new Vehiculo();
            vehiculo7.Placa1 = "DIS-843";
            vehiculo7.Propietario = Propietario4;
            vehiculo7.Modelo1 = "Disney";
            vehiculo7.MarcaVehiculo1 = "Royal";
            vehiculo7.TipoVehiculo1 = "Maritimo";
            vehiculo7.Capacidad1 = 25;

            Vehiculo vehiculo8 = new Vehiculo();
            vehiculo8.Placa1 = "ASD-917";
            vehiculo8.Propietario = Propietario4;
            vehiculo8.Modelo1 = "12-BUGA";
            vehiculo8.MarcaVehiculo1 = "AeroSokovia";
            vehiculo8.TipoVehiculo1 = "AeroNave";
            vehiculo8.Capacidad1 = 3;

            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            Vehiculos.Add(vehiculo1);
            Vehiculos.Add(vehiculo2);
            Vehiculos.Add(vehiculo3);
            Vehiculos.Add(vehiculo4);
            Vehiculos.Add(vehiculo5);
            Vehiculos.Add(vehiculo6);
            Vehiculos.Add(vehiculo7);
            Vehiculos.Add(vehiculo8);
     
            //Mostrar DATOS
            Console.WriteLine("SOKOVIA");
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("a)Mostrar datos de los propietarios");//Listo
            Console.WriteLine("b)Mostrar cantidad total de vehículos registrados");//Listo
            Console.WriteLine("c)Mostrar cantidad total de vehículos de cada tipo");//Listo
            Console.WriteLine("d)Marca mas registrada");//Listo
            Console.WriteLine("e)Tipo de  Vehículo más común");//Listo
            Console.WriteLine("f)Lista de todos los dueños");//Listo
            Console.WriteLine("g)Lista de dueños por género (H o M)");//Listo
            Console.WriteLine("h)Lista de dueños por edad");//Listo
            Console.WriteLine("i)Lista de empresas con más vehículos");//Listo  
            Console.WriteLine("j)Listar cantidad de vehículos por cantidad de pasajeros y por tipo");//Listo
            String Respuesta = Console.ReadLine();
            Console.Clear();
            if (Respuesta == "A" || Respuesta == "a")
            {
                Console.WriteLine(" VEHICULOS SOKOVIA");

                vehiculo1.mostrar();
                Console.WriteLine();
                vehiculo1.mostrar_Propietario();
                Console.WriteLine("Presiones una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                vehiculo2.mostrar();
                Console.WriteLine();
                vehiculo2.mostrar_Propietario();
                Console.WriteLine("Presiones una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                vehiculo3.mostrar();
                vehiculo4.mostrar();
                Console.WriteLine();
                vehiculo3.mostrar_Propietario();
                Console.WriteLine("Presiones una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                vehiculo5.mostrar();
                vehiculo6.mostrar();
                vehiculo7.mostrar();
                vehiculo8.mostrar();
                Console.WriteLine();
                vehiculo5.mostrar_Propietario();
                Console.WriteLine("Presiones una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            }
            //Cantidad total de vehículos
            else if (Respuesta == "B" || Respuesta == "b")
            {
                int countveh = 0;
                for (int a = 0; a < Vehiculos.Count; a++)
                {
                    countveh++;
                    Console.WriteLine($"Vehiculos Registrados:{Vehiculos[a].MarcaVehiculo1}  || Modelo: {Vehiculos[a].Modelo1} || Placa: {Vehiculos[a].Placa1}");

                }
                Console.WriteLine("Total de vehículos registrados: " + countveh);
                Console.ReadKey();

            }
            //Cantidad total de cada vehículo
            else if (Respuesta == "C" || Respuesta == "c")
            {
                int CVT = 0, CVM = 0, CVE = 0, CVA = 0; //Count Vehiculo : Terrestre, Maritimo, Espacial, Aereo
                for (int a = 0; a < Vehiculos.Count; a++)
                {
                    if (Vehiculos[a].TipoVehiculo1 == "Terrestre")
                    {
                        CVT++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "AeroNave")
                    {
                        CVA++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Espacial")
                    {
                        CVE++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Maritimo")
                    {
                        CVM++;
                    }
                }
                Console.WriteLine("Terrestres: " + CVT);
                Console.WriteLine("Maritimos: " + CVM);
                Console.WriteLine("AeroNaves: " + CVA);
                Console.WriteLine("Espaciales: " + CVE);
                Console.ReadKey();
            }
            //Marca más registrada
            else if (Respuesta == "D" || Respuesta == "d")
            {
                //Terrestre
                int CMVN = 0, CMVC = 0, CMVH = 0, CMVT = 0, CMVF = 0;
                //Maritimos
                int CMVB = 0, CMVR = 0, CMVCR = 0;
                //Espaciales
                int CMVS = 0, CMVNASA = 0;
                //Aeronave
                int CMVA = 0, CMVSO = 0;
                int Max = 0, maxmar = 0;
                for (int i = 0; i < Vehiculos.Count; i++)
                {
                    if (Vehiculos[i].MarcaVehiculo1 == "Nissan")
                    {
                        CMVN++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Chevrolet")
                    {
                        CMVC++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Honda")
                    {
                        CMVH++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Toyota")
                    {
                        CMVT++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Ferrari")
                    {
                        CMVF++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Budge")
                    {
                        CMVB++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Royal")
                    {
                        CMVR++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "Crystal")
                    {
                        CMVCR++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "SpaceX")
                    {
                        CMVS++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "NASA")
                    {
                        CMVNASA++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "AeroNaves")
                    {
                        CMVA++;
                    }
                    else if (Vehiculos[i].MarcaVehiculo1 == "AeroSokovia")
                    {
                        CMVSO++;
                    }
                    int[] datos = { CMVN, CMVC, CMVH, CMVT, CMVF, CMVB, CMVR, CMVCR, CMVS, CMVNASA, CMVA, CMVSO };
                    for (int x = 0; x < datos.Length; x++)
                    {
                        if (datos[x] > Max)
                        {
                            Max = datos[x];
                            maxmar = x;
                        }
                    }
                }
                string[] marca = { "Nissan", "Chevrolet", "Honda", "Toyota", "Ferrari", "Budge", "Royal", "Crystal", "SpaceX", "NASA", "AeroNaves", "AeroSokovia" };
                Console.WriteLine($"La marca más registrada hasta el momento es {marca[maxmar]} Con: {Max} unidades registradas");
                Console.ReadKey();
            }
            //Tipo de vehiculo más común
            else if (Respuesta == "E" || Respuesta == "e")
            {
                int CVTE = 0, CVMA = 0, CVES = 0, CVAE = 0, maxi = 0, maxTV = 0; //Count Vehiculo : Terrestre, Maritimo, Espacial, Aereo
                for (int a = 0; a < Vehiculos.Count; a++)
                {
                    if (Vehiculos[a].TipoVehiculo1 == "Terrestre")
                    {
                        CVTE++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "AeroNave")
                    {
                        CVAE++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Espacial")
                    {
                        CVES++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Maritimo")
                    {
                        CVMA++;
                    }
                    int[] datosveh = { CVTE, CVAE, CVES, CVMA };
                    for (int x = 0; x < datosveh.Length; x++)
                    {
                        if (datosveh[x] > maxi)
                        {
                            maxi = datosveh[x];
                            maxTV = x;
                        }
                    }
                }
                string[] tipo = { "Terrestre", "AeroNave", "Espacial", "Maritimo" };
                Console.WriteLine($"El tipo de vehiculo más común es: {tipo[maxTV]} Con: {maxi} unidades registradas");
                Console.ReadKey();
            }
            //LISTA DE TODOS LOS DUEÑOS
            else if (Respuesta == "F" || Respuesta == "f")
            {
                for (int a = 0; a < Propietarios.Count; a++)
                {

                    Console.WriteLine("ID:" + Propietarios[a].Id_propietario);
                    Console.WriteLine("Nombre: " + Propietarios[a].NombreCompleto);
                    Console.WriteLine("Tipo de Propietario: " + Propietarios[a].TipoPropietario1);
                    Console.WriteLine();

                }

                Console.ReadKey();
            }
            //GENERO 
            else if (Respuesta == "G" || Respuesta == "g")
            {
                List<Propietario> GenHM = new List<Propietario>();
                for (int i = 0; i < Propietarios.Count; i++)
                {
                    if (Propietarios[i].Genero1 == "Hombre" || Propietarios[i].Genero1 == "Mujer")
                    {
                        GenHM.Add(Propietarios[i]);
                        for (int x = 0; x < GenHM.Count; x++)
                        {
                            if (Propietarios[x] != GenHM[i])
                            {
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Genero:" + GenHM[x].Genero1 + " Nombre: " + Propietarios[i].NombreCompleto);
                            }
                        }
                    }

                }
                Console.ReadKey();

            }
            //Lista de dueños por edad
            else if (Respuesta == "H" || Respuesta == "h")
            {
                List<Propietario> edad = new List<Propietario>();
                for (int i = 0; i < Propietarios.Count; i++)
                {
                    edad.Add(Propietarios[i]);
                    for(int x = 0; x < edad.Count; x++)
                    {
                        if(Propietarios[x] != edad[i])
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Edad: " + edad[i].Edad + " Nombre: " + Propietarios[x].NombreCompleto);
                        }
                    }
                }
                Console.ReadKey();
            }
            //Lista de empresas con más vehiculos
            else if(Respuesta == "I" || Respuesta == "i")
            {
                for(int x = 0; x < Propietarios.Count; x++)
                {
                    if (Propietarios[x].TipoLicencia1 == "Tipo C(Empresa)")
                    {
                        for (int a = 0; a < Propietarios.Count; a++) 
                        {
                            if (Propietarios[a].CantidadV1 != Propietarios[x].CantidadV1)
                            {
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("La empresa " + Propietarios[x].TipoPropietario1 + " Tiene más vehículos registrados");
                            }
                        }
                            
                    }
                }
                Console.WriteLine("Se debe tomar este dato ^");
                Console.ReadKey();
            }
            //Tipo, cantidad, cantidad vehículos
            else if(Respuesta=="J" || Respuesta == "j")
            {
                List<Vehiculo> TipoVehiculo = new List<Vehiculo>();
                int CVTER = 0, CVMAR = 0, CVESP = 0, CVAER = 0; //Count Vehiculo : Terrestre, Maritimo, Espacial, Aereo
                for (int a = 0; a < Vehiculos.Count; a++)
                {
                    if (Vehiculos[a].TipoVehiculo1 == "Terrestre")
                    {
                        CVTER++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "AeroNave")
                    {
                        CVAER++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Espacial")
                    {
                        CVESP++;
                    }
                    else if (Vehiculos[a].TipoVehiculo1 == "Maritimo")
                    {
                        CVMAR++;
                    }
                    TipoVehiculo.Add(Vehiculos[a]);
                    for(int b = 0; b < TipoVehiculo.Count; b++)
                    {
                       if(Vehiculos[b] != TipoVehiculo[a])
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Vehiculos "+ Vehiculos[b].TipoVehiculo1 + " de: " + TipoVehiculo[a].Capacidad1 + " Pasajeros");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Cantidad de vehículos existentes");
                Console.WriteLine();
                Console.WriteLine("Vehiculos Terrestres: " + CVTER);
                Console.WriteLine("Vehiculos Maritimos: " + CVMAR);
                Console.WriteLine("Vehiculos AeroNaves: " + CVAER);
                Console.WriteLine("Vehiculos Espaciales: " + CVESP);
                Console.ReadKey();
            }
        }
    }
}
