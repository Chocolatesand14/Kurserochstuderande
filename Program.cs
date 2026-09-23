using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar kurser
        Kurs programmering = new Kurs("Programmering", 2);
        Kurs matematik = new Kurs("Matematik", 3);
        Kurs bildOchForm = new Kurs("Bild och Form", 4);
        Kurs psykologi = new Kurs("Psykologi", 2);


        // Skapar studenter
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");
        Student draven = new Student("Draven");


        // Alice läggs till via kursen
        programmering.LäggTillStudent(alice);

        programmering.VisaStudenter();
        alice.VisaKurser();


        // Bob läggs till via studenten
        bob.BörjaKurs(programmering);

        programmering.VisaStudenter();
        bob.VisaKurser();


        // Testar vad som händer när kursen är full
        draven.BörjaKurs(programmering);


        // Testar att lägga till samma student igen
        bob.BörjaKurs(programmering);


        // Visar alla studenters kurser
        Console.WriteLine("\n--- Studenternas kurser ---");

        alice.VisaKurser();
        bob.VisaKurser();
        draven.VisaKurser();


        // Tar bort Alice från kursen
        programmering.TaBortStudent(alice);

        Console.WriteLine("\n--- Efter att Alice tagits bort ---");

        programmering.VisaStudenter();
        alice.VisaKurser();


        // Försöker ta bort en student som inte går kursen
        programmering.TaBortStudent(draven);


        // Alice börjar kursen igen
        alice.BörjaKurs(programmering);

        Console.WriteLine("\n--- Alice går med igen ---");

        programmering.VisaStudenter();
        alice.VisaKurser();


        // Testar ToString()
        Console.WriteLine("\n--- Kurser ---");

        Console.WriteLine(programmering);
        Console.WriteLine(matematik);
        Console.WriteLine(bildOchForm);
        Console.WriteLine(psykologi);
    }
}