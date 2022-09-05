// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

//Console.WriteLine("Hello, World!");

Studerende S1 = new Studerende("Freja", 05, 06);
Studerende S2 = new Studerende("Hasibe", 06, 04);
Studerende S3 = new Studerende("Alex", 07, 01);

//Console.WriteLine(S1);

 List<Studerende> studerendeListe=new List<Studerende>();
studerendeListe.Add(S1);
studerendeListe.Add(S2);
studerendeListe.Add(S3);

KlasseRum K1 = new KlasseRum("B3", studerendeListe, new DateOnly(2022,09,01));

Console.WriteLine(K1);
