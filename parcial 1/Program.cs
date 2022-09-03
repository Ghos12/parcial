using System;
using System.Collections;

namespace parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int validador = 0;
            do
            {
                Console.WriteLine("Ingrese el numero de estudiantes");
                int numStudents = int.Parse(Console.ReadLine());
                int contador = 0;
                ArrayList lista = new ArrayList();
                string nombre;
                double laboratorio1;
                double laboratorio2;
                double parcial;

                while (contador <= numStudents)
                {
                    Console.WriteLine("Ingrese el nombre del estudiante");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota del laboratorio 1");
                    laboratorio1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del laboratorio 2");
                    laboratorio2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota de el parcial");
                    parcial = double.Parse(Console.ReadLine());

                    double notaFinal = NotaFinal(laboratorio1, laboratorio2, parcial);
                    string apr = Aprob(notaFinal);

                    Estudiantes estudiantes = new Estudiantes { Nombre = nombre, NotaFinal = notaFinal, Aprobado = apr };
                    lista.Add(estudiantes);

                    contador++;
                }

                foreach (Estudiantes st in lista)
                {
                    Console.WriteLine(st.GetData());
                }

                Console.WriteLine("");
                Console.WriteLine("si quiere ingresar nuevos datos, escriba 1 y de click en enter");
            } while (validador == 0);

            static double NotaFinal(double laboratorio1,double laboratorio2,double parcial)
            {
                double notaFinal = (laboratorio1 * 0.3) + (laboratorio2 * 0.3) + (parcial * 0.4);
                return notaFinal;
            }

            static string Aprob(double NotaFinal)
            {
                if(NotaFinal > 6)
                {
                    return "aprobado";
                }
                else
                {
                    return "reprobado";
                }
            }
        }
    }
}

public class Estudiantes
{
    
    private string _nombre;
    private double _notaFinal;
    private string _aprobado;

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public double NotaFinal
    {
        get => _notaFinal;
        set => _notaFinal = value;

    }

    public string Aprobado
    {
        get => _aprobado;
        set => _aprobado = value;
    }

    public string GetData()
    {
        return "El nombre del estudiante es:" + _nombre + "La nota final es:" +_notaFinal + "por lo tanto el estudiante esta:" + Aprobado;
    }
}
