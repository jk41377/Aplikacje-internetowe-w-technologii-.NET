using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvConverter csv = new CsvConverter();
            csv.CsvToHtml("plik.csv", "index.html");

            Father ojciec = new Father("Super", "Ojciec");
            Son syn = new Son("Super", "Syn");

            Party.InviteToParty(ojciec);
            Console.WriteLine();
            Party.InviteToParty(syn);
        }
    }
}
