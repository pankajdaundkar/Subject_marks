using System.Xml.Schema;

int marathi, hindi, english, total, perc;

Console.WriteLine("Enter marathi marks");

marathi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entre hindi marks");

hindi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entre english marks");

english = Convert.ToInt32(Console.ReadLine());

total = marathi + hindi + english;
Console.WriteLine($"total of three subject is ={total}");

perc = (marathi + hindi + english) / 3;
Console.WriteLine($"percentage of three sub is = {perc}");
