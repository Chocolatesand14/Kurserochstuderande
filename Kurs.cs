using System;
using System.Collections.Generic;

public class Kurs
{
    // Kursens namn
    public string KursNamn { get; set; }

    // Maximalt antal studenter som kan registreras i kursen
    public int MaxAntalStudenter { get; set; }

    // Lista över studenter som är registrerade i kursen
    public List<Student> Studenter { get; set; }


    // Kursen skapas med ett namn och ett maximalt antal studenter
    public Kurs(string kursNamn, int maxAntalStudenter = 30)
    {
        KursNamn = kursNamn;
        MaxAntalStudenter = maxAntalStudenter;
        Studenter = new List<Student>();
    }


    // Används för att registrera en student i kursen
    public bool RegistreraStudent(Student student)
    {
        // Kollar om studenten redan är registrerad
        if (Studenter.Contains(student))
        {
            Console.WriteLine(
                $"Studenten {student.Namn} är redan registrerad i kursen {KursNamn}."
            );

            return false;
        }

        // Kollar om kursen är full
        if (Studenter.Count >= MaxAntalStudenter)
        {
            Console.WriteLine(
                $"Kursen {KursNamn} är full. Kan inte registrera fler studenter."
            );

            return false;
        }

        // Lägger till studenten i listan
        Studenter.Add(student);

        return true;
    }
}