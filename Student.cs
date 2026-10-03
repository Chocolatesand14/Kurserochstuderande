using System;
using System.Collections.Generic;

public class Student
{
    // Studentens namn.
    public string Name { get; set; }

    // Lista med kurser som studenten är med i.
    public List<Course> Courses { get; set; }


    // Skapar en ny student och sparar studentens namn.
    public Student(string name)
    {
        Name = name;

        // Skapar en tom lista där studentens kurser kan läggas till.
        Courses = new List<Course>();
    }


    // Lägger till studenten på en kurs.
    public void Join(Course course)
    {
        // Skickar studenten till kursens metod för att lägga till studenten.
        course.Enroll(this);
    }


    // Tar bort studenten från en kurs.
    public void Leave(Course course)
    {
        // Skickar studenten till kursens metod för att ta bort studenten.
        course.Remove(this);
    }


    // Visar vilka kurser studenten går.
    public void Schedule()
    {
        Console.WriteLine();
        Console.WriteLine($"Kurser för {Name}:");

        // Kontrollerar om studenten inte går någon kurs.
        if (Courses.Count == 0)
        {
            Console.WriteLine("Studenten har inga kurser.");
            return;
        }


        // Går igenom studentens kurser och visar kursnamnen.
        foreach (Course course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }


    // Gör att studentens namn visas när objektet skrivs ut.
    public override string ToString()
    {
        return Name;
    }
}