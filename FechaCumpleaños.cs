public class cumpleañosAmigo {
    public static void Ejecutar() {
        Console.WriteLine("Ingrese la cantidad de amigos:");
        int cantidadAmigos = int.Parse(Console.ReadLine());

        Amigo[] amigos = new Amigo[cantidadAmigos];

        // Ingreso de datos de amigos
        for (int i = 0; i < cantidadAmigos; i++) {
            Amigo amigo = new Amigo();
            Console.WriteLine($"Ingrese los datos del amigo {i + 1}:");
            Console.WriteLine("Nombre:");
            amigo.Nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Día de cumpleaños:");
            amigo.Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes de cumpleaños:");
            amigo.Mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año de cumpleaños:");
            amigo.Anio = int.Parse(Console.ReadLine());

            amigos[i] = amigo;
        }

        // Consulta de cumpleaños en un mes específico
        Console.WriteLine("Ingrese el número de mes para verificar los cumpleaños:");
        int mesConsulta = int.Parse(Console.ReadLine());

        int cumpleañosEnMes = 0;
        foreach (Amigo amigo in amigos) {
            if (amigo.Mes == mesConsulta) {
                cumpleañosEnMes++;
                Console.WriteLine($"{amigo.Nombre} cumple años el {amigo.Dia}/{amigo.Mes}/{amigo.Anio}");
                Console.WriteLine($"Nombre completo: {amigo.NombreCompleto()}");
                Console.WriteLine($"¿Es mayor de edad? {amigo.EsMayorEdad()}");
                Console.WriteLine($"Edad: {amigo.ObtenerEdad()}");
                Console.WriteLine(amigo.ObtenerDetalles());
            }
        }

        Console.WriteLine($"En el mes {mesConsulta} hay {cumpleañosEnMes} amigo(s) que cumplen años.");
    }
}
