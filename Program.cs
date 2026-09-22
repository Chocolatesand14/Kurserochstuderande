using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapa kurser
        Kurs programmering = new Kurs("Programmering", 2);
        Kurs matematik = new Kurs("Matematik", 3);
        Kurs bildOchForm = new Kurs("Bild och Form", 4);
        Kurs psykologi = new Kurs("Psykologi", 2);

        // Skapa studenter
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");
        Student draven = new Student("Draven");

        // ==========================================
        // Alice registreras via kursen
        // ==========================================

        programmering.RegistreraStudent(alice);

        programmering.NärvaroLista();
        alice.SkrivUtSchema();


        // ==========================================
        // Bob registreras via studenten
        // ==========================================

        bob.RegistreraIEnKurs(programmering);

        programmering.NärvaroLista();
        bob.SkrivUtSchema();


        // ==========================================
        // Testa full kurs
        // ==========================================

        draven.RegistreraIEnKurs(programmering);


        // ==========================================
        // Testa dubbelregistrering
        // ==========================================

        bob.RegistreraIEnKurs(programmering);


        // ==========================================
        // Visa scheman
        // ==========================================

        Console.WriteLine("\n--- Scheman ---");

        alice.SkrivUtSchema();
        bob.SkrivUtSchema();
        draven.SkrivUtSchema();


        // ==========================================
        // Ta bort Alice
        // ==========================================

        programmering.AvregistreraStudent(alice);

        Console.WriteLine("\n--- Efter att Alice avregistrerats ---");

        programmering.NärvaroLista();
        alice.SkrivUtSchema();


        // ==========================================
        // Testa att ta bort någon som inte finns
        // ==========================================

        programmering.AvregistreraStudent(draven);


        // ==========================================
        // Alice går med igen
        // ==========================================

        alice.RegistreraIEnKurs(programmering);

        Console.WriteLine("\n--- Alice går med igen ---");

        programmering.NärvaroLista();
        alice.SkrivUtSchema();


        // ==========================================
        // Testa ToString()
        // ==========================================

        Console.WriteLine("\n--- Kurser ---");

        Console.WriteLine(programmering);
        Console.WriteLine(matematik);
        Console.WriteLine(bildOchForm);
        Console.WriteLine(psykologi);
    }
}