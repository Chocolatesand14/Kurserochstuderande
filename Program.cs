using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar kurser med ett kursnamn och ett maxantal studenter.
        Course programmering = new Course("Programmering", 2);
        Course matematik = new Course("Matematik", 3);
        Course bildOchForm = new Course("Bild och Form", 4);
        Course psykologi = new Course("Psykologi", 2);


        // Skapar tre studenter.
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");
        Student draven = new Student("Draven");


        // Lägger till Alice på programmeringskursen genom kursen.
        programmering.Enroll(alice);

        // Visar vilka studenter som går programmeringskursen.
        programmering.RollCall();

        // Visar vilka kurser Alice går.
        alice.Schedule();


        // Lägger till Bob på programmeringskursen genom studenten.
        bob.Join(programmering);

        // Visar vilka studenter som går programmeringskursen.
        programmering.RollCall();

        // Visar vilka kurser Bob går.
        bob.Schedule();


        // Testar vad som händer när kursen är full.
        draven.Join(programmering);


        // Testar vad som händer när samma student försöker gå kursen igen.
        bob.Join(programmering);


        // Visar vilka kurser varje student går.
        Console.WriteLine("\n--- Studenternas kurser ---");

        alice.Schedule();
        bob.Schedule();
        draven.Schedule();


        // Tar bort Alice från programmeringskursen.
        programmering.Remove(alice);

        Console.WriteLine("\n--- Efter att Alice tagits bort ---");

        // Visar vilka studenter som är kvar på kursen.
        programmering.RollCall();

        // Visar vilka kurser Alice går efter att hon tagits bort.
        alice.Schedule();


        // Testar vad som händer när man försöker ta bort en student
        // som inte går på kursen.
        programmering.Remove(draven);


        // Lägger till Alice på programmeringskursen igen.
        alice.Join(programmering);

        Console.WriteLine("\n--- Alice går med igen ---");

        // Visar att Alice nu finns på kursen igen.
        programmering.RollCall();

        // Visar att programmering finns bland Alices kurser igen.
        alice.Schedule();


        // Testar ToString() för att visa information om kurserna.
        Console.WriteLine("\n--- Kurser ---");

        Console.WriteLine(programmering);
        Console.WriteLine(matematik);
        Console.WriteLine(bildOchForm);
        Console.WriteLine(psykologi);
    }
}