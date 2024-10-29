using Practico11ProgI.Entidades;

namespace Practico11ProgI.Datos
{
    public class RepositorioDeSocios
    {
        private readonly char separatorChar = '|';
        private string archivo = "Socios.txt";
        private string rutaTrabajo = AppDomain.CurrentDomain.BaseDirectory;
        private List<Persona>? socios;
        public RepositorioDeSocios()
        {
            socios = new List<Persona>();
            LeerDatos();
            
        }
        public void Agregar(Persona persona)
        {
            socios!.Add(persona);
            
        }
        public List<Persona>? GetSocios() => socios;

        public Categoria GetCategoria(Persona persona)
        {
            if (persona.GetEdad() <= 12)
            {
                return Categoria.Menor;

            }else if (persona.GetEdad() <= 18)
            {
                return Categoria.Juvenil;
            }else if (persona.GetEdad() <= 40)
            {
                return Categoria.Mayor;
            }
            else
            {
                return Categoria.Vitalicio;
            }
        }

        public void GuardarDatos()
        {
            var rutaArchivo = Path.Combine(rutaTrabajo, archivo);
            using (var escritor=new StreamWriter(rutaArchivo))
            {
                foreach (var persona in socios!)
                {
                    string linea = ConstruirLinea(persona);
                    escritor.WriteLine(linea);
                }
                
            }
            
        }

        private string ConstruirLinea(Persona persona)
        {
            return $"{persona.Dni}|{persona.PrimerNombre}|{persona.SegundoNombre}|{persona.TercerNombre}|{persona.Apellido}|{persona.FechaNacimiento.ToShortDateString()}|{persona.Genero.GetHashCode()}|{persona.Localidad.GetHashCode()}|{persona.Activo}";
        }

        private void LeerDatos()
        {
            var rutaArchivo = Path.Combine(rutaTrabajo, archivo);
            if (!File.Exists(rutaArchivo)) return;
            using (var lector=new StreamReader(rutaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine()!;
                    Persona persona = ConstruirPersona(linea);
                    Agregar(persona);

                }
            }
        }

        private Persona ConstruirPersona(string linea)
        {
            var campos=linea.Split(separatorChar);
            var dni = int.Parse(campos[0]);
            var pNombre = campos[1];
            var sNombre = campos[2];
            var tNombre = campos[3];
            var apellido = campos[4];
            var fechaNac = DateTime.Parse(campos[5]);
            Genero genero=(Genero)int.Parse(campos[6]);
            Localidad localidad =(Localidad) int.Parse(campos[7]);
            bool activo=bool.Parse(campos[8]);
            return new Persona
            {
                Dni = dni,
                PrimerNombre = pNombre,
                SegundoNombre = sNombre,
                TercerNombre = tNombre,
                Apellido = apellido,
                FechaNacimiento = fechaNac,
                Localidad = localidad,
                Genero = genero,
                Activo = activo

            };
        }
        public int GetCantidad()
        {
            return socios!.Count;
        }

        public void Borrar(Persona persona)
        {
            socios!.Remove(persona);
        }

        public List<Persona>? FiltrarPorGenero(Genero genero)
        {
            return socios!.Where(s=>s.Genero==genero).ToList();
        }

        public int GetCantidad(Genero genero)
        {
            return socios!.Count(s => s.Genero == genero);
        }

        public bool BuscarPorDni(int dniBuscado)
        {
            return socios!.Any(s => s.Dni == dniBuscado);
        }

        public List<Persona>? OrdernarAsc()
        {
            return socios!.OrderBy(s => s.GetEdad()).ToList();
        }

        public List<Persona>? OrdernarDesc()
        {
            return socios!.OrderByDescending(s => s.GetEdad()).ToList();
        }

        public List<Persona>? OrdenarAlfa()
        {
            return socios!.OrderBy(s => s.Apellido)
                .ThenBy(s => s.PrimerNombre)
                .ThenBy(s => s.SegundoNombre)
                .ThenBy(s => s.TercerNombre).ToList();
        }
    }
}
