
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Inicialización de datos del alumno
            Alumno alumno = new Alumno
            {
                Nombre = "Hugo Salvador Duron Molina",
                NumeroCuenta = "T32521199",
                Email = "hugo_salvador@unitec.edu"
            };

            // Inicialización de datos de la asignatura
            Asignatura asignatura = new Asignatura
            {
                NombreAsignatura = "Programación II",
                NombreDocente = "Ing. Roger Gurdián",
                Horario = "Lunes, Miércoles y viernes 18:00-19:30"
            };

            Matricula matricula = new Matricula
            {
                Alumno = alumno,
                Asignatura = asignatura
            };

            // Solicitar notas al usuario
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE NOTAS ===");
            Console.WriteLine($"Alumno: {alumno.Nombre}");
            Console.WriteLine($"Número de cuenta: {alumno.NumeroCuenta}");
            Console.WriteLine($"e-mail: {alumno.Email}");
            Console.WriteLine($"Asignatura: {asignatura.NombreAsignatura}");
            Console.WriteLine($"Docente: {asignatura.NombreDocente}");
            Console.WriteLine($"Horario: {asignatura.Horario}");
            
            Console.WriteLine();

            double nota1, nota2, nota3;

            Console.Write("Ingrese la nota del primer parcial (0-30): ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del segundo parcial (0-30): ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del tercer parcial (0-40): ");
            nota3 = double.Parse(Console.ReadLine());

            // Llamada al metodo para validar las notas
            matricula.ValidarNotas(nota1, nota2, nota3);

            // Almacenar notas en la lista
            matricula.NotasParciales.Add(nota1);
            matricula.NotasParciales.Add(nota2);
            matricula.NotasParciales.Add(nota3);

            // Calcular nota final de dos maneras diferentes
            double notaFinalMetodo1 = matricula.CalcularNotaFinal(); // Método de la interfaz
            double notaFinalMetodo2 = matricula.CalcularNotaFinal(nota1, nota2, nota3); // Método sobrecargado

            // Mostrar resultados
            Console.WriteLine();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"Nota final (método interfaz): {notaFinalMetodo1}% - {matricula.ObtenerMensajeNota(notaFinalMetodo1)}");
            Console.WriteLine($"Nota final (método sobrecargado): {notaFinalMetodo2}% - {matricula.ObtenerMensajeNota(notaFinalMetodo2)}");


        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese valores numéricos válidos para las notas.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}