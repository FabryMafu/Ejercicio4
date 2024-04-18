class Amigo {
    public string Nombre { get; set; }
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Anio { get; set; }
    
        public void SetFechaNacimiento(int dia, int mes, int anio)
    {
        Dia = dia;
        Mes = mes;
        Anio = anio;
    }
public bool EsMayorEdad()
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - Anio;
        if (fechaActual.Month < Mes || (fechaActual.Month == Mes && fechaActual.Day < Dia))
        {
            edad--;
        }
        return edad >= 18;
    }
    public string NombreCompleto()
    {
        return Nombre;
    }
    public int ObtenerEdad()
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - Anio;
        if (fechaActual.Month < Mes || (fechaActual.Month == Mes && fechaActual.Day < Dia))
        {
            edad--;
        }
        return edad;
    }
    public string ObtenerDetalles()
    {
        string mayorEdad = EsMayorEdad() ? "Mayor de edad" : "Menor de edad";
        return $"{NombreCompleto()}, Fecha de nacimiento: {Dia}/{Mes}/{Anio}, Edad: {ObtenerEdad()} y es {mayorEdad}";
    }
}