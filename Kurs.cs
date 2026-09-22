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
          if (!student.Kurser.Contains(this))
        {
            student.Kurser.Add(this);
        }

        return true;
    }
  
    // Används för att avregistrera en student från kursen
    public void AvregistreraStudent(Student student)
    {
        if (!Studenter.Contains(student))
        {
            Console.WriteLine(
                $"Studenten {student.Namn} är inte registrerad i kursen {KursNamn}."
            );
            return;
        }
    
        //Avregistrerar studenten från kursen
        Studenter.Remove(student);

        //Avregistrerar kursen från studentens lista av kurser
        if (student.Kurser.Contains(this))
        {
            student.Kurser.Remove(this);
        }
    }
    //Skriver ut alla studenter som är registrerade i kursen
    public void NärvaroLista()
    {
        Console.WriteLine($"Närvaro lista för kursen: {KursNamn}");
     
         if (Studenter.Count == 0)
        {
            Console.WriteLine("Inga studenter registrerade i kursen.");
            return;
        }

            foreach (Student student in Studenter)
            {
                Console.WriteLine($"- {student.Namn}");
            }
        }

        //Skriver ut kursens namn och antal registrerade studenter
        public override string ToString()
        {
            return $"Kurs: {KursNamn}, Registrerade studenter: {Studenter.Count}/{MaxAntalStudenter}";
        }
}