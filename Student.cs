using System;
using System.Collections.Generic;

public class Student
{
    // Studentens namn
    public string Namn { get; set; }

    // Kurser som studenten går
    public List<Kurs> Kurser { get; set; }

    // Konstruktor
    public Student(string namn)
    {
        Namn = namn;
        Kurser = new List<Kurs>();
    }

    // Registrera studenten i en kurs
    public void RegistreraIEnKurs(Kurs kurs)
    {
        kurs.RegistreraStudent(this);
    }

    // Avregistrera studenten från en kurs
    public void AvregistreraFrånEnKurs(Kurs kurs)
    {
        kurs.AvregistreraStudent(this);
    }

    // Skriver ut studentens kurser
    public void SkrivUtSchema()
    {
        Console.WriteLine($"\nSchema för {Namn}:");

        if (Kurser.Count == 0)
        {
            Console.WriteLine("Inga kurser registrerade.");
            return;
        }

        foreach (Kurs kurs in Kurser)
        {
            Console.WriteLine($"- {kurs.KursNamn}");
        }
    }

    // Skriver ut studentens namn
    public override string ToString()
    {
        return Namn;
    }
}