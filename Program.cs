// See https://aka.ms/new-console-template for more information
using CSV_class_maker;

Console.WriteLine("CSV_class_maker, paste list of fields and press ENTER");

List<string> linieIn = new();

string? input = "";

do
{
    input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input) )
    {
        linieIn.Add(input);
    }



} while (!string.IsNullOrEmpty(input));




List<CSVClassMaker> makery = new();

foreach (string line in linieIn)
{

    CSVClassMaker maker = new();

    maker.NazwaPola = line;

    makery.Add(maker);

 
}



foreach(CSVClassMaker maker in makery)
{
    Console.WriteLine($"public string {maker.NazwaIdentyfikatora} {{ get; set; }}");
}


foreach (CSVClassMaker maker in makery)
{
    Console.WriteLine($"Map(m=>m.{maker.NazwaIdentyfikatora}).Name(\"{maker.NazwaPola}\");");
}
