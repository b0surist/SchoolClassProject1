using System;
using SchoolClassProject;

SchoolClass class1 = new SchoolClass(9, "a", 7000, 30);
Console.WriteLine(class1);
SchoolClass class2 = new SchoolClass(9, "b", 6000, 30);
Console.WriteLine(class2);

if(class1.Penz > class2.Penz)
{
    int kulonb = class1.Penz - class2.Penz;
    Console.WriteLine($"{class1.Evfolyam}. {class1.OsztalyID} osztály diákjai havonta {kulonb} forinttal fizettek többet osztálypénzbe mint {class2.Evfolyam}. {class2.OsztalyID} osztály tanulói");
}
else if(class2.Penz > class1.Penz)
{
    int kulonb = class2.Penz - class1.Penz;
    Console.WriteLine($"{class2.Evfolyam}. {class2.OsztalyID} osztály diákjai havonta {kulonb} forinttal fizettek többet osztálypénzbe mint {class1.Evfolyam}. {class1.OsztalyID} osztály tanulói");
}
else{
    Console.WriteLine($"{class1.Evfolyam}. {class1.OsztalyID} és {class2.Evfolyam}. {class2.OsztalyID} osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.");
}

Console.WriteLine($"A {class1.Evfolyam}. {class1.OsztalyID} osztály ennyi osztálypénzt fizetett be 10 hónap alatt: " + class1.Penz * 10 * 30);
Console.WriteLine($"A {class2.Evfolyam}. {class2.OsztalyID} osztály ennyi osztálypénzt fizetett be 10 hónap alatt: " + class2.Penz * 10 * 30);
