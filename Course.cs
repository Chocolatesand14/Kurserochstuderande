// Gör det möjligt att använda Console och andra klasser från System.
using System;

// Gör det möjligt att använda List.
using System.Collections.Generic;


public class Course
{
    // Information om kursen.
    public string Name { get; set; }
    public int MaxSeats { get; set; }

    // Lista med alla studenter som går kursen.
    public List<Student> Students { get; set; }

    // Skapar en ny kurs och anger kursens namn och max antal studenter.
    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
        // Skapar en tom lista där studenterna kan läggas till.
        Students = new List<Student>();
    
    } 


    // Lägger till en student på kursen.
    public void Enroll(Student student)
    {
        // Kontrollerar om studenten redan finns på kursen.
        if (Students.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} finns redan på kursen {Coursename}."
            );

            return;
        }


        // Kontrollerar om kursen redan har nått maxantalet studenter.
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine(
                $"Det finns inga lediga platser på {KursNamn}."
            );

            return;
        }


        // Lägger till studenten i kursens lista.
        Students.Add(student);


        // Lägger även till kursen i studentens lista över kurser.
        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }


        Console.WriteLine(
            $"{student.Namn} är nu registrerad på {Coursename}."
        );
    }


    // Tar bort en student från kursen.
    public void Remove(Student student)
    {
        // Kontrollerar om studenten finns på kursen.
        if (!Students.Contains(student))
        {
            Console.WriteLine(
                $"{student.Namn} går inte på {KursNamn}."
            );

            return;
        }


        // Tar bort studenten från kursens lista.
        Students.Remove(student);


        // Tar även bort kursen från studentens lista över kurser.
        student.Courses.Remove(this);


        Console.WriteLine(
            $"{student.Namn} har tagits bort från {KursNamn}."
        );
    }


    // Visar vilka studenter som går kursen.
    public void RollCall()
    {
        Console.WriteLine();
        Console.WriteLine($"Studenter på {KursNamn}:");


        // Kontrollerar om det finns några registrerade studenter.
        if (Students.Count == 0)
        {
            Console.WriteLine("Det finns inga registrerade studenter.");
            return;
        }


        // Går igenom listan och visar varje students namn.
        foreach (Student student in Students)
        {
            Console.WriteLine(student.Namn);
        }
    }


    // Visar kursens namn och hur många platser som används.
    public override string ToString()
    {
        return $"{Name} - {Students.Count} av {MaxSeats} platser används";
    }
}

