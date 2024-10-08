internal class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;
        int estudiantesGanaron = 0;
        int estudiantesPerdieron = 0;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("Ingrese la nota 1:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Ingrese la nota 2:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Ingrese la nota 3:");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Ingrese la nota 4:");
            double nota4 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio >= 4.5)
            {
                Console.WriteLine("");
                Console.WriteLine($"El estudiante {nombre} esta en la categoria: \nEXCELENTE");
                Console.WriteLine("");

            }
            else if (promedio >= 4.0 && promedio <= 4.4)
            {
                Console.WriteLine("");
                Console.WriteLine($"El estudiante {nombre} esta en la categoria: \nSOBRESALIENTE");
                Console.WriteLine("");

            }
            else if(promedio >= 3.5 && promedio <= 3.9)
            {
                Console.WriteLine("");
                Console.WriteLine($"El estudiante {nombre} esta en la categoria: \nBUENO");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"El estudiante {nombre} esta en la categoria de: \nINSUFICIENTE");
                Console.WriteLine("");

            }

            if (promedio >= 3.0)
            {
                estudiantesGanaron++;
            }
            else
            {
                estudiantesPerdieron++;
            }
           
            Console.WriteLine("");
            Console.WriteLine("¿Desea ingresar otro estudiante? (SI/NO)");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta != "SI")
            {
                continuar = false;
                Console.WriteLine($"\nEstudiantes que ganaron:{estudiantesGanaron}");
                Console.WriteLine($"\nEstudiantes que perdieron:{estudiantesPerdieron}");
                Console.WriteLine("");
            }

        } while (continuar);
    }
}