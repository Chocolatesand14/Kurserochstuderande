using System;
using System.Collections.Generic;

public class Student
{
    // Studentens namn
    public string Namn { get; set; }

    // Kurser som studenten är med i
    public List<Kurs> Kurser { get; set; }


    // Skapar en ny student
    public Student(string namn)
    {
        Namn = namn;
        Kurser = new List<Kurs>();
    }


    // Lägger till studenten på en kurs
    public void BörjaKurs(Kurs kurs)
    {
        kurs.LäggTillStudent(this);
    }


    // Tar bort studenten från en kurs
    public void SlutaKurs(Kurs kurs)
    {
        kurs.TaBortStudent(this);
    }


    // Visar studentens kurser
    public void VisaKurser()
    {
        Console.WriteLine();
        Console.WriteLine($"Kurser för {Namn}:");

        if (Kurser.Count == 0)
        {
            Console.WriteLine("Studenten har inga kurser.");
            return;
        }

        foreach (Kurs kurs in Kurser)
        {
            Console.WriteLine(kurs.KursNamn);
        }
    }


    // Gör att studentens namn visas som text
    public override string ToString()
    {
        return Namn;
    }
}