//Skapa en kurs och registrera en student i kursen
        Kurs programmering = new Kurs("Programmering", 2);  
        Kurs matematik = new Kurs("Matematik", 3);
        Kurs bildOchForm = new Kurs("Bild och Form", 4);
        Kurs psykologi = new Kurs("Psykologi", 2);

        //Skapa studenter
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");
        Student draven = new Student("Draven");

        //Registrera Alice via kursen Programmering
        programmering.RegistreraStudent(alice);

        //Visa kursens studenter
        programmering.NärvaroLista();

        //Visa studentens schema
        alice.SkrivUtSchema();

        //Registrera Bob via kursen Programmering
        bob.RegistreraIEnKurs(programmering);

        //Visa kursens studenter
        programmering.NärvaroLista();

        //Visa Bobs kurslista
        bob.SkrivUtSchema();

        //Ska testa om kursen är full genom att registrera Draven i kursen Programmering
        draven.RegistreraIEnKurs(programmering);

        //Ta bort dubbelregistrering av Bob i kursen Programmering
        programmering.RegistreraStudent(bob);

        //Ska testa att avregistrera Alice från kursen Programmering
        programmering.AvregistreraStudent(alice);

        Console.WriteLine();

        Console.WriteLine("Efter avregistrering av Alice från kursen Programmering:");
        //Visa kursens studenter efter avregistrering av Alice

        programmering.NärvaroLista();
        alice.SkrivUtSchema();

        //Ska resta att avregistrera en student som inte är registrerad i kursen



