internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        bool continuar = true;
        int MaxNum = 0;
        Random random = new Random();
        int num = random.Next(0, MaxNum + 1);
        

        do
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Seleccione la cantidad de jugadores que desean jugar: ");
            Console.WriteLine("Presiona 1, Para 2 Jugadores ");
            Console.WriteLine("Presiona 2, Para 3 Jugadores ");
            Console.WriteLine("Presiona 3, Para 4 Jugadores ");
            Console.WriteLine("Presiona 0, Para salir del juego ");
            Console.WriteLine("-------------------------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    continuar = false;
                    Console.WriteLine("Saliendo del juego...");
                    break;

                case 1:
                    MaxNum = 50;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 2 Jugadores:");
                    Console.WriteLine("A continuación se ha generado un número entre 0 y 50: ");
                    break;

                case 2:
                    MaxNum = 100;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 2 Jugadores:");
                    Console.WriteLine("Se ha generado un número entre 0 y 50: ");
                    break;

                case 3:
                    MaxNum = 200;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 2 Jugadores:");
                    Console.WriteLine("Se ha generado un número entre 0 y 50: ");
                    break;

                default:
                    continuar = false;
                    Console.WriteLine("Opción no válida. Saliendo del juego...");
                    break;

            }


        } while (continuar);

    }
}