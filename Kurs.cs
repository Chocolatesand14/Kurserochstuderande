using System;
using System.Collections.Generic;

public class Kurs
{
    // Kursens namn
    public string KursNamn { get; set; }

    // Maximalt antal studenter
    public int MaxAntalStudenter { get; set; }

    // Lista över studenter
    public List<Student> Studenter { get; set; }

    // Konstruktor
    public Kurs(string kursNamn, int maxAntalStudenter)
    {
        KursNamn = kursNamn;
        MaxAntalStudenter = maxAntalStudenter;
        Studenter = new List<Student>();
    }

    // Registrerar en student
    public void RegistreraStudent(Student student)
    {
        // Kontrollera dubbelregistrering
        if (Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} är redan registrerad i {KursNamn}."
            );

            return;
        }

        // Kontrollera om kursen är full
        if (Studenter.Count >= MaxAntalStudenter)
        {
            Console.WriteLine(
                $"Kursen {KursNamn} är full."
            );

            return;
        }

        // Lägg till studenten i kursen
        Studenter.Add(student);

        // Lägg till kursen hos studenten
        if (!student.Kurser.Contains(this))
        {
            student.Kurser.Add(this);
        }

        Console.WriteLine(
            $"{student.Namn} har registrerats i {KursNamn}."
        );
    }

    // Avregistrerar en student
    public void AvregistreraStudent(Student student)
    {
        if (!Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} är inte registrerad i {KursNamn}."
            );

            return;
        }

        // Ta bort studenten från kursen
        Studenter.Remove(student);

        // Ta bort kursen från studentens lista
        if (student.Kurser.Contains(this))
        {
            student.Kurser.Remove(this);
        }

        Console.WriteLine(
            $"{student.Namn} har avregistrerats från {KursNamn}."
        );
    }

    // Skriver ut alla studenter i kursen
    public void NärvaroLista()
    {
        Console.WriteLine($"\nNärvarolista för {KursNamn}:");

        if (Studenter.Count == 0)
        {
            Console.WriteLine("Inga studenter registrerade.");
            return;
        }

        foreach (Student student in Studenter)
        {
            Console.WriteLine($"- {student.Namn}");
        }
    }

    // Skriver ut kursens information
    public override string ToString()
    {
        return $"{KursNamn} ({Studenter.Count}/{MaxAntalStudenter} platser)";
    }
}