
using System;
using System.Collections.Generic;

public class Kurs
{
    // Information om kursen
    public string KursNamn { get; set; }
    public int MaxAntalStudenter { get; set; }

    // Studenter som går kursen
    public List<Student> Studenter { get; set; }


    // Skapar en ny kurs
    public Kurs(string kursNamn, int maxAntalStudenter)
    {
        KursNamn = kursNamn;
        MaxAntalStudenter = maxAntalStudenter;
        Studenter = new List<Student>();
    }


    // Lägger till en student på kursen
    public void LäggTillStudent(Student student)
    {
        if (Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} finns redan på kursen {KursNamn}."
            );

            return;
        }


        if (Studenter.Count == MaxAntalStudenter)
        {
            Console.WriteLine(
                $"Det finns inga lediga platser på {KursNamn}."
            );

            return;
        }


        Studenter.Add(student);


        // Kursen läggs även till hos studenten
        if (!student.Kurser.Contains(this))
        {
            student.Kurser.Add(this);
        }


        Console.WriteLine(
            $"{student.Namn} är nu registrerad på {KursNamn}."
        );
    }


    // Tar bort en student från kursen
    public void TaBortStudent(Student student)
    {
        if (!Studenter.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} går inte på {KursNamn}."
            );

            return;
        }


        Studenter.Remove(student);


        // Tar även bort kursen från studenten
        student.Kurser.Remove(this);


        Console.WriteLine(
            $"{student.Namn} har tagits bort från {KursNamn}."
        );
    }


    // Visar vilka studenter som går kursen
    public void VisaStudenter()
    {
        Console.WriteLine();
        Console.WriteLine($"Studenter på {KursNamn}:");


        if (Studenter.Count == 0)
        {
            Console.WriteLine("Det finns inga registrerade studenter.");
            return;
        }


        foreach (Student student in Studenter)
        {
            Console.WriteLine(student.Namn);
        }
    }


    // Visar kursens namn och antal platser
    public override string ToString()
    {
        return $"{KursNamn} - {Studenter.Count} av {MaxAntalStudenter} platser används";
    }
}

