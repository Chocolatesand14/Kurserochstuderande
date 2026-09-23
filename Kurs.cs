// Gör det möjligt att använda Console och andra klasser från System.
using System;

// Gör det möjligt att använda List.
using System.Collections.Generic;


public class Kurs
{
    // Information om kursen.
    public string KursNamn { get; set; }
    public int MaxAntalStudenter { get; set; }

    // Lista med alla studenter som går kursen.
    public List<Student> Studenter { get; set; }


    // Skapar en ny kurs och anger kursens namn och max antal studenter.
    public Kurs(string kursNamn, int maxAntalStudenter)
    {
        KursNamn = kursNamn;
        MaxAntalStudenter = maxAntalStudenter;

        // Skapar en tom lista där studenterna kan läggas till.
        Studenter = new List<Student>();
    }


    // Lägger till en student på kursen.
    public void LäggTillStudent(Student student)
    {
        // Kontrollerar om studenten redan finns på kursen.
        if (Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} finns redan på kursen {KursNamn}."
            );

            return;
        }


        // Kontrollerar om kursen redan har nått maxantalet studenter.
        if (Studenter.Count >= MaxAntalStudenter)
        {
            Console.WriteLine(
                $"Det finns inga lediga platser på {KursNamn}."
            );

            return;
        }


        // Lägger till studenten i kursens lista.
        Studenter.Add(student);


        // Lägger även till kursen i studentens lista över kurser.
        if (!student.Kurser.Contains(this))
        {
            student.Kurser.Add(this);
        }


        Console.WriteLine(
            $"{student.Namn} är nu registrerad på {KursNamn}."
        );
    }


    // Tar bort en student från kursen.
    public void TaBortStudent(Student student)
    {
        // Kontrollerar om studenten finns på kursen.
        if (!Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} går inte på {KursNamn}."
            );

            return;
        }


        // Tar bort studenten från kursens lista.
        Studenter.Remove(student);


        // Tar även bort kursen från studentens lista över kurser.
        student.Kurser.Remove(this);


        Console.WriteLine(
            $"{student.Namn} har tagits bort från {KursNamn}."
        );
    }


    // Visar vilka studenter som går kursen.
    public void VisaStudenter()
    {
        Console.WriteLine();
        Console.WriteLine($"Studenter på {KursNamn}:");


        // Kontrollerar om det finns några registrerade studenter.
        if (Studenter.Count == 0)
        {
            Console.WriteLine("Det finns inga registrerade studenter.");
            return;
        }


        // Går igenom listan och visar varje students namn.
        foreach (Student student in Studenter)
        {
            Console.WriteLine(student.Namn);
        }
    }


    // Visar kursens namn och hur många platser som används.
    public override string ToString()
    {
        return $"{KursNamn} - {Studenter.Count} av {MaxAntalStudenter} platser används";
    }
}

