using System; // Necesario para Console y otros tipos básicos

// Define un espacio de nombres para organizar tu código
namespace RegistroEstudiantesApp
{
    // *** Definición de la Clase Estudiante ***
    public class Estudiante
    {
        // Propiedades (Campos)
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        
        // Arreglo (Array) para almacenar los 3 números de teléfono
        // Inicializado a tamaño 3 al crear la instancia
        public string[] Telefonos { get; set; } = new string[3];

        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion)
        {
            this.ID = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
        }

        // Método para mostrar la información
        public void MostrarInformacion()
        {
            Console.WriteLine("\n--- Información del Estudiante Registrado ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            
            Console.WriteLine("Teléfonos:");
            // Recorre el arreglo para imprimir los datos
            for (int i = 0; i < Telefonos.Length; i++)
            {
                // Muestra la posición del array (i) y el número guardado
                Console.WriteLine($"  Teléfono {i + 1} (Índice {i}): {Telefonos[i]}");
            }
            Console.WriteLine("---------------------------------------------");
        }
    }

    // *** Clase principal que contiene la lógica de inicio ***
    class Program
    {
        // El método Main es el punto de entrada de la aplicación
        static void Main(string[] args)
        {
            Console.WriteLine("--- INICIO: Registro de Estudiante ---");

            // --- 1. Solicitud de Datos ---

            // ID: Manejo de errores de conversión explícito
            int idEstudiante = 0;
            bool entradaValida = false;
            
            // Loop para asegurar una entrada numérica válida para el ID
            while (!entradaValida)
            {
                Console.Write("Ingrese el ID del estudiante (número): ");
                string inputID = Console.ReadLine();
                if (int.TryParse(inputID, out idEstudiante))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("ERROR: El ID debe ser un número entero válido. Intente de nuevo.");
                }
            }

            Console.Write("Ingrese los nombres: ");
            string nombresEstudiante = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese los apellidos: ");
            string apellidosEstudiante = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese la dirección: ");
            string direccionEstudiante = Console.ReadLine() ?? string.Empty;

            // --- 2. Creación del Objeto ---
            Estudiante nuevoEstudiante = new Estudiante(
                idEstudiante,
                nombresEstudiante,
                apellidosEstudiante,
                direccionEstudiante
            );

            // --- 3. Solicitud y Almacenamiento de Teléfonos (Array) ---
            Console.WriteLine("\n--- Ingrese los 3 Números de Teléfono ---");

            // nuevoEstudiante.Telefonos.Length siempre será 3
            for (int i = 0; i < nuevoEstudiante.Telefonos.Length; i++)
            {
                Console.Write($"Ingrese Teléfono {i + 1}: ");
                // Almacenamos directamente la entrada en la posición 'i' del array.
                nuevoEstudiante.Telefonos[i] = Console.ReadLine() ?? string.Empty;
            }

            // --- 4. Mostrar el Registro ---
            nuevoEstudiante.MostrarInformacion();

            Console.WriteLine("\n--- FIN DEL PROGRAMA (Presione cualquier tecla para salir) ---");
            // Espera una tecla para que la ventana de la consola no se cierre inmediatamente
            Console.ReadKey();
        }
    }
}