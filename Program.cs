﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Lade till en ny klass för att köra programmet, så lade VSC in en massa kod själv. Jag ska se hur det fungerar 
class Program
{
    static void Main(string[] args)
    {
        // Skapa några kurser
        Kurs kurs1 = new Kurs("Matematik");
        Kurs kurs2 = new Kurs("Fysik");
        Kurs kurs3 = new Kurs("Kemi");

        // Skapa några studenter
        Student student1 = new Student("Alice", "Ahlquist", 20);
        Student student2 = new Student("Bob", "Bergström", 22);
        Student student3 = new Student("Charlie", "Carlsson", 21);

        // Registrera studenter i kurser
        student1.RegistreraIEnKurs(kurs1);
        student1.RegistreraIEnKurs(kurs2);
        student2.RegistreraIEnKurs(kurs1);
        student3.RegistreraIEnKurs(kurs3);

        // Skriv ut scheman för studenter
        student1.SkrivUtSchema();
        student2.SkrivUtSchema();
        student3.SkrivUtSchema();

        // Avregistrera en student från en kurs
        student1.AvregistreraFrånEnKurs(kurs2);

        // Skriv ut schemat igen efter avregistrering
        Console.WriteLine("\nEfter avregistrering:");
        student1.SkrivUtSchema();
    }
}   

