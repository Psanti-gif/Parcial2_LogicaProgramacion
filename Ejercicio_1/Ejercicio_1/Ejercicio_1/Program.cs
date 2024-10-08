internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        bool continuar = true;       

        do
        {
            Console.Clear();
            int MaxNum = 0;
            int numero_J = 0;
            Random random = new Random();
            int num = 0;
            

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
                    numero_J = 2;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 2 Jugadores:");
                    Console.WriteLine("A continuación se ha generado un número entre 0 y 50: ");
                    break;

                case 2:
                    MaxNum = 100;
                    numero_J = 3;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 3 Jugadores:");
                    Console.WriteLine("Se ha generado un número entre 0 y 100: ");
                    break;

                case 3:
                    MaxNum = 200;
                    numero_J = 4;
                    num = random.Next(0, MaxNum + 1);
                    Console.WriteLine("Has seleccionado la opcion de 4 Jugadores:");
                    Console.WriteLine("Se ha generado un número entre 0 y 200: ");
                    break;

                default:
                    continuar = false;
                    Console.WriteLine("Opción no válida. Saliendo del juego...");
                    break;

            }
            if (continuar && numero_J > 1)
            {
                bool finalizado = true;
                int turno = 1;
                while (finalizado)
                {
                    Console.WriteLine($"Turno del jugador: {turno}");
                    Console.WriteLine("Ingresa el número que crees que es:");
                    int intento = int.Parse(Console.ReadLine());
                    if (intento > num)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else if (intento < num)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else 
                    {
                        Console.WriteLine("Has Ganado");
                    }
                }

        } while (continuar);

    }
}