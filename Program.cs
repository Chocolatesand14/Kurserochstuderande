using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Programmet som kör våra kurser och studenter
class Program
{
    static void Main(string[] args)
    {
        // Skapa kurser
        Kurs programmering = new Kurs("Programmering");
        Kurs matematik = new Kurs("Matematik");
        Kurs bildOchForm = new Kurs("Bild och Form");
        Kurs psykologi = new Kurs("Psykologi");

        // Skapa studenter
        Student alice = new Student("Alice", "Ahlquist", 20);
        Student bob = new Student("Bob", "Bergström", 22);
        Student draven = new Student("Draven", "Andersson", 21);

        // Registrera Alice i Programmering
        programmering.RegistreraStudent(alice);

        // Visa kursens studenter
        programmering.NärvaroLista();

        // Visa Alice schema
        alice.SkrivUtSchema();

        // Registrera Bob i Programmering via studenten
        bob.RegistreraIEnKurs(programmering);

        // Visa kursens studenter
        programmering.NärvaroLista();

        // Visa Bobs schema
        bob.SkrivUtSchema();

        // Försök registrera Draven i Programmering
        draven.RegistreraIEnKurs(programmering);

        // Försök registrera Bob igen
        // Detta testar dubbelregistrering
        programmering.RegistreraStudent(bob);

        // Avregistrera Alice från Programmering
        programmering.AvregistreraStudent(alice);

        Console.WriteLine("\nEfter avregistrering av Alice från Programmering:");

        // Visa kursens studenter efter avregistrering
        programmering.NärvaroLista();

        // Visa Alice schema efter avregistrering
        alice.SkrivUtSchema();

        // Försök avregistrera Draven
        // Draven är inte registrerad i kursen
        programmering.AvregistreraStudent(draven);
    }
}


