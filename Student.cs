using System;
using System.Collections.Generic;

// Student-klassen representerar en student med namn, ålder och en lista av kurser som studenten är registrerad i.
public class Student
{

    // String bestående av fält med: namn, ålder och lista av kurser.
    public string Namn { get; set; }
    public string Tilltalsnamn { get; set; }
    public string Efternamn { get; set; }
    public int Ålder { get; set; }
    public List<Kurs> Kurser { get; set; }

    public Student(string tilltalsnamn, string efternamn, int ålder)
    {
        Tilltalsnamn = tilltalsnamn;
        Efternamn = efternamn;
        Ålder = ålder;
        Namn = $"{tilltalsnamn} {efternamn}";
        Kurser = new List<Kurs>();
    }

    // Metod för att registrera en student i en kurs
    public bool RegistreraIEnKurs(Kurs kurs)
    {
    kurs.RegistreraStudent(this);
    }

    // Metod för att avregistrera en student från en kurs
    public void AvregistreraFrånEnKurs(Kurs kurs)
    {
    kurs.Studenter.Remove(this);
    }

    //Metod för skriva ut studentens schema med kurser och deras namn
    public void SkrivUtSchema()
    {
        Console.WriteLine($"Schema - Student: {Namn}, Ålder: {Ålder}");
    if (Kurser.Count == 0)
    //Felmeddelande om inga kurser är registrerade
        {
            Console.WriteLine("Inga kurser registrerade.");
        }
        else
        {
            Console.WriteLine("Registrerade kurser:");
            foreach (var kurs in Kurser)
            {
                Console.WriteLine($"- {kurs.KursNamn}");
            }
        }
    }