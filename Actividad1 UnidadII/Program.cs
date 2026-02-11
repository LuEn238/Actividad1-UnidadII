namespace Actividad1_UnidadII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string edad, cantidadPersonas;
            int cantper, ed;
            string nombre;
            bool isValid, edIsValid;
            List<String> Listanommen = []; 
            List<String> Listanommay = [];
            List<int> Listaedmen = [];
            List<int> Listaedmay = [];
            do
            {


                Console.WriteLine("¿Cuantas personas vas a registrar?");
                cantidadPersonas = Console.ReadLine();
                //cantidadPersonas
                try
                {
                    cantper = Convert.ToInt16(cantidadPersonas);
                    isValid = false;
                    if (cantper > 0)
                    {
                        if (cantper == 1)
                        {
                            Console.WriteLine("Escribe el nombre de la persona");
                            nombre = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Escribe la edad de la persona");
                                edad = Console.ReadLine();
                                try
                                {
                                    ed = Convert.ToInt16(edad);
                                    edIsValid = false;
                                    if(ed > 0)
                                    {
                                        if (ed >= 18)
                                        {
                                            Console.WriteLine(nombre + " es mayor de edad con " + edad + " años");
                                        }
                                        else
                                        {
                                            Console.WriteLine(nombre + " es menor de edad con " + edad + " años");
                                        }
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("valor inválido, por favor, escriba un número");
                                    edIsValid = true;
                                }
                            } while (edIsValid);
                        }
                        else
                        {
                            for (int i = 1; i <= cantper; i++)
                            {
                                Console.WriteLine("Ingrese el nombre de la persona "+i);
                                nombre = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("Ingrese la edad de la persona " + i);
                                    edad = Console.ReadLine();
                                    try
                                    {
                                        ed = Convert.ToInt16(edad);
                                        if (ed > 0)
                                        {
                                            if (ed >= 18)
                                            {
                                                Listanommay.Add(nombre);
                                                Listaedmay.Add(ed);
                                            }
                                            else
                                            {
                                                Listanommen.Add(nombre);
                                                Listaedmen.Add(ed);
                                            }
                                        } else
                                        {
                                            Console.WriteLine("Edad inválida, no se registró");
                                        }
                                        edIsValid = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("valor inválido, por favor, escriba un número");
                                        edIsValid = true;
                                    }
                                } while(edIsValid);
                                
                            }
                            Console.WriteLine("Lista de personas mayores");
                            for (int j = 0; j < Listaedmay.Count; j++)
                            {
                                Console.WriteLine(Listanommay[j] + " - " + Listaedmay[j]);
                            }
                            Console.WriteLine("Lista de personas menores");
                            for (int j = 0; j < Listaedmen.Count; j++)
                            {
                                Console.WriteLine(Listanommen[j] + " - " + Listaedmen[j]);
                            }

                        }

                    } else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                catch
                {
                    Console.WriteLine("valor inválido, por favor, escriba un número");
                    isValid = true;
                }
            } while (isValid);
        }
    }
}
