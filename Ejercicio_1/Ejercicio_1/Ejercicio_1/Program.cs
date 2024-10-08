internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        bool continuar = true;
        Random num = new Random();

        do
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Seleccione la cantidad de jugadores que desean jugar: ");
            Console.WriteLine("Presiona 1, Para 2 Jugadores ");
            Console.WriteLine("Presiona 2, Para 3 Jugadores ");
            Console.WriteLine("Presiona 3, Para 4 Jugadores ");
            Console.WriteLine("-------------------------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    continuar = false;
                    break;

                case 1:
                    Console.WriteLine("Has seleccionado la opción para 2 jugadores: ");


                    break;

            }


        } while (continuar);

    }
}