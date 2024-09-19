namespace ProyectowebApi.Controllers
{
    public class Alumno
    {
        //Creando Propiedades 
        string Nombre;
        string apellido;
        string dni;
        DateTime fechanacimiento;

        //Constructor sin parametros
        public Alumno()
        {
            Nombre = string.Empty;
            apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
        }

        //Constructor con parametros
        public Alumno(string pNombre, string pApellido, string pdni)
        {
            Nombre= pNombre;
            apellido= pApellido;
            dni= pdni;
        }

        public Alumno(string pNombre, string pApellido, string pdni, DateTime pfechanacimiento)
        {
            Nombre = pNombre;
            apellido = pApellido;
            dni = pdni;
            fechanacimiento= pfechanacimiento;
        }
        public string DevolverNombreCompleto()
        {
            return Nombre + "" + apellido;
        }

        public string DevolverDocumento()
        {
            return dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }


    }
}
