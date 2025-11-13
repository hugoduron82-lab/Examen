using System.Collections.Generic;

public class Matricula : ICalculoNota
{
    public Alumno Alumno { get; set; }
    public Asignatura Asignatura { get; set; }
    public List<double> NotasParciales { get; set; }

    public Matricula()
    {
        NotasParciales = new List<double>();
    }

    // Implementación de la interfaz ICalculoNota
    public double CalcularNotaFinal()
    {
        double suma = 0;
        foreach (double nota in NotasParciales)
        {
            suma += nota;
        }
        return suma;
    }

    // Método sobrecargado
    public double CalcularNotaFinal(double n1, double n2, double n3)
    {
        return n1 + n2 + n3;
    }

    // Método para obtener mensaje de acuerdo a la nota
    public string ObtenerMensajeNota(double notaFinal)
    {
        if (notaFinal >= 0 && notaFinal <= 59)
            return "Reprobado";
        else if (notaFinal >= 60 && notaFinal <= 79)
            return "Bueno";
        else if (notaFinal >= 80 && notaFinal <= 89)
            return "Muy Bueno";
        else if (notaFinal >= 90 && notaFinal <= 100)
            return "Sobresaliente";
        else
            return "Nota fuera de rango";
    }

    // Método para validar notas 
    public void ValidarNotas(double n1, double n2, double n3)
    {
        if (n1 > 30)
        {
            throw new ArgumentException("Error: El primer parcial no puede ser mayor a 30");
        }

        if (n2 > 30)
        {
            throw new ArgumentException("Error: El segundo parcial no puede ser mayor a 30");
        }

        if (n3 > 40)
        {
            throw new ArgumentException("Error: El tercer parcial no puede ser mayor a 40");
        }
    }
}