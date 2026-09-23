using System;
using System.Collections.Generic;

public class Student
{
    // Studentens namn.
    public string Namn { get; set; }

    // Lista med kurser som studenten är med i.
    public List<Kurs> Kurser { get; set; }


    // Skapar en ny student och sparar studentens namn.
    public Student(string namn)
    {
        Namn = namn;

        // Skapar en tom lista där studentens kurser kan läggas till.
        Kurser = new List<Kurs>();
    }


    // Lägger till studenten på en kurs.
    public void BörjaKurs(Kurs kurs)
    {
        // Skickar studenten till kursens metod för att lägga till studenten.
        kurs.LäggTillStudent(this);
    }


    // Tar bort studenten från en kurs.
    public void SlutaKurs(Kurs kurs)
    {
        // Skickar studenten till kursens metod för att ta bort studenten.
        kurs.TaBortStudent(this);
    }


    // Visar vilka kurser studenten går.
    public void VisaKurser()
    {
        Console.WriteLine();
        Console.WriteLine($"Kurser för {Namn}:");


        // Kontrollerar om studenten inte går någon kurs.
        if (Kurser.Count == 0)
        {
            Console.WriteLine("Studenten har inga kurser.");
            return;
        }


        // Går igenom studentens kurser och visar kursnamnen.
        foreach (Kurs kurs in Kurser)
        {
            Console.WriteLine(kurs.KursNamn);
        }
    }


    // Gör att studentens namn visas när objektet skrivs ut.
    public override string ToString()
    {
        return Namn;
    }
}