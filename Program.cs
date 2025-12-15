// *** Definición de la Clase Estudiante ***
public class Estudiante
{
    // Propiedades (Campos)
    public int ID { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    
    // Arreglo (Array) para almacenar los 3 números de teléfono
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
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
        Console.WriteLine("---------------------------------------------");
    }
}


// *** Lógica Principal de la Aplicación ***

Console.WriteLine("--- INICIO: Registro de Estudiante ---");

// --- 1. Solicitud de Datos ---

Console.Write("Ingrese el ID del estudiante (número): ");
int idEstudiante;
if (!int.TryParse(Console.ReadLine(), out idEstudiante))
{
    idEstudiante = 0;
    Console.WriteLine("ADVERTENCIA: ID inválido. Usando ID: 0");
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

for (int i = 0; i < nuevoEstudiante.Telefonos.Length; i++)
{
    Console.Write($"Ingrese Teléfono {i + 1} (Índice {i}): ");
    // La asignación usa la notación de arreglo (índice)
    nuevoEstudiante.Telefonos[i] = Console.ReadLine() ?? string.Empty;
}

// --- 4. Mostrar el Registro ---
nuevoEstudiante.MostrarInformacion();

Console.WriteLine("\n--- FIN DEL PROGRAMA ---");
// Línea opcional para mantener la consola abierta en algunos entornos
Console.ReadLine();