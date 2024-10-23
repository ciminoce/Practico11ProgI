namespace Practico11ProgI.Entidades
{
    public class Persona
    {
        public int Dni { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? TercerNombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }
        public Localidad Localidad { get; set; }
        public bool Activo { get; set; }
        public string NombreCompleto()
        {
            if(!string.IsNullOrEmpty(TercerNombre))
            {
                return $"{Apellido!.ToUpper()}, {PrimerNombre} {SegundoNombre} {TercerNombre![0]}.";

            }
            return $"{Apellido!.ToUpper()}, {PrimerNombre} {SegundoNombre}";

        }
        public int GetEdad()
        {
            return (int) Math.Truncate(DateTime.Today.Subtract(FechaNacimiento).TotalDays / 365.25);
        }
    }
}
