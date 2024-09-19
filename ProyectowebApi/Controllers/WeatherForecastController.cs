using Microsoft.AspNetCore.Mvc;

namespace ProyectowebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("DevolverValor")]
        public int DevolverValor()
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;
            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num3;
        }
        [HttpGet("DevolverSaludo")]
        public String DevolverSaludo()
        {
            string variable1 = "pedro";
            string variable2 = "juean";
            string variable3 = variable1 + variable2;

            int num1 = 7;
            string variable4 = variable3 + num1;
            string mensaje = "Hola " + variable4;
            return mensaje;

        }

        [HttpGet("DevolverMayor/{num1}/{num2}")]
        public String DevolverMayor(int num1, int num2)
        {
            if (num1 > num2)
            {
                return "El mayor es " + num1.ToString();
            }
            else
            {
                return "El mayor es" + num2.ToString();
            }

        }

        [HttpGet("DevolverEstado/{edad}/{Nombre}")]
        public String DevolverEstado(int edad, string Nombre)
        {
            string mensaje = "";
            if (edad >= 18)
            {
                mensaje = "Sr(a)" + Nombre + " es mayor de edad";
            }
            else
            {
                mensaje = "Sr(a)" + Nombre + "es menor de edad";
            }
            return mensaje;
        }

        //TAREA SEMANA 4

        [HttpGet("calculararea/{largo}/{ancho}")]
        public String CalcularArea(int largo, int ancho)
        {
            int area = largo * ancho;

            return $"Su área es {area} metros cuadrados";
        }

        //EJERCICIO 2

        [HttpGet("calcularedad/{anioNacimiento}/{nombre}")]
        public String CalcularEdad(int anioNacimiento, string nombre)
        {
            int anioActual = DateTime.Now.Year;

            int edad = anioActual - anioNacimiento;

            return $"Sr(a) {nombre}, su edad es {edad} años";
        }

        //EJERCICIO 3

        [HttpGet("calculargeneracion/{anioNacimiento}")]
        public String CalcularGeneracion(int anioNacimiento)
        {
            int anioActual = DateTime.Now.Year;

            int edad = anioActual - anioNacimiento;

            if (edad >= 18 && edad <= 20)
            {
                return "Usted es de la generación Z";
            }
            else
            {
                return "Usted no es de la generación Z";
            }
        }


        [HttpGet("DevolverAlumno")]
        public int DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno3 = new Alumno("Delia", "Alava", "63154219", new DateTime(2005, 5, 14));
            return Alumno3.DevolverEdad();
        }
    }
}
