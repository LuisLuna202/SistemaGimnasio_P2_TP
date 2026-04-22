using SistemaGestionGimnasio.Gestores;
using SistemaGestionGimnasio.Servicios;
using SistemaGestionGimnasio.Modelos; 

Console.WriteLine("Gym Mama2");


Console.WriteLine("Ingrese el nombre del usuario:");
string nombreUsuario = Console.ReadLine() ?? "";
Console.WriteLine("Ingrese la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ingrese el objetivo:");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Entrenador 

Console.WriteLine("Ingrese el nombre del entrenador :");
string nombreEntrenador = Console.ReadLine() ?? "";
Console.WriteLine("Ingrese la especialidad:");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador,especialidadEntrenador);

//Crear Rutinas 
Console.WriteLine("Ingrese el nombre de la rutina ");
string nombreRutina= Console.ReadLine() ?? "";
Console.WriteLine("Ingrese la duracion de la rutina:");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina  = new Rutina (nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina 

Console.WriteLine("Ingrese cuantos ejercicios tendra su rutina");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i=1; i<=numEjercicios; i++)
{
    Console.WriteLine($"Ejercicio{i}");
    Console.WriteLine("Nombre del ejercicio");
    string nombreEjericio = Console.ReadLine() ?? "";
    Console.WriteLine("Ingrese numero de repeticiones:");
    int repeticionesEjercicio  = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Ingrese el numero de series:");
    int seriesEjercicio = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Ingrese el tiempo de descanso:");
    int descansoEjercicio = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjericio, repeticionesEjercicio, seriesEjercicio, descansoEjercicio);
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutina y entrenador a usuarii 

AsignadorRutinas asignador = new AsignadorRutinas();

asignador.AsignarRutinaaUsuario(usuario,rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostra resumen 

Console.WriteLine("RESUMEN DE ASIGNACION");

Console.WriteLine($"Usuario{usuario.Nombre},| Objetivo {usuario.Objetivo}");
Console.WriteLine($"Rutina asignada{usuario.RutinaAsignada.Nombre}|{usuario.RutinaAsignada.Duracion} segundos");
Console.WriteLine($"Entrenador:{entrenador.Nombre}");


GestorUsuarios gestorUsuarios=new GestorUsuarios();
gestorUsuarios.CrearUsuario(usuario.Nombre, usuario.Edad, usuario.Objetivo);

