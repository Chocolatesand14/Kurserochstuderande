using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar kurser med ett kursnamn och ett maxantal studenter.
        Kurs programmering = new Kurs("Programmering", 2);
        Kurs matematik = new Kurs("Matematik", 3);
        Kurs bildOchForm = new Kurs("Bild och Form", 4);
        Kurs psykologi = new Kurs("Psykologi", 2);


        // Skapar tre studenter.
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");
        Student draven = new Student("Draven");


        // Lägger till Alice på programmeringskursen genom kursen.
        programmering.LäggTillStudent(alice);

        // Visar vilka studenter som går programmeringskursen.
        programmering.VisaStudenter();

        // Visar vilka kurser Alice går.
        alice.VisaKurser();


        // Lägger till Bob på programmeringskursen genom studenten.
        bob.BörjaKurs(programmering);

        // Visar vilka studenter som går programmeringskursen.
        programmering.VisaStudenter();

        // Visar vilka kurser Bob går.
        bob.VisaKurser();


        // Testar vad som händer när kursen är full.
        draven.BörjaKurs(programmering);


        // Testar vad som händer när samma student försöker gå kursen igen.
        bob.BörjaKurs(programmering);


        // Visar vilka kurser varje student går.
        Console.WriteLine("\n--- Studenternas kurser ---");

        alice.VisaKurser();
        bob.VisaKurser();
        draven.VisaKurser();


        // Tar bort Alice från programmeringskursen.
        programmering.TaBortStudent(alice);

        Console.WriteLine("\n--- Efter att Alice tagits bort ---");

        // Visar vilka studenter som är kvar på kursen.
        programmering.VisaStudenter();

        // Visar vilka kurser Alice går efter att hon tagits bort.
        alice.VisaKurser();


        // Testar vad som händer när man försöker ta bort en student
        // som inte går på kursen.
        programmering.TaBortStudent(draven);


        // Lägger till Alice på programmeringskursen igen.
        alice.BörjaKurs(programmering);

        Console.WriteLine("\n--- Alice går med igen ---");

        // Visar att Alice nu finns på kursen igen.
        programmering.VisaStudenter();

        // Visar att programmering finns bland Alices kurser igen.
        alice.VisaKurser();


        // Testar ToString() för att visa information om kurserna.
        Console.WriteLine("\n--- Kurser ---");

        Console.WriteLine(programmering);
        Console.WriteLine(matematik);
        Console.WriteLine(bildOchForm);
        Console.WriteLine(psykologi);
    }
}