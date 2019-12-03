using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLStructure.InputDocumentStructure;

namespace XMLParser.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting XML Parser");

            Console.WriteLine("Opening the input file");
            StreamReader lStreamReader = new StreamReader("InputFile.xml");

            Console.WriteLine("Parsing XML File");
            InputDocument lInputDocument = ParseXML.Parse<InputDocument>(lStreamReader);

            PrintResult(lInputDocument);

            Console.WriteLine("XML Parser execution has finished");
            Console.ReadLine();
        }

        static void PrintResult(InputDocument pInputDocument)
        {
            if (pInputDocument == null
                || pInputDocument.DeclarationList == null
                || pInputDocument.DeclarationList.Declaration == null
                || pInputDocument.DeclarationList.Declaration.DeclarationHeader == null)
            {
                Console.WriteLine("Error during file parsing");
                return;
            }

            string[] lCodes = new string[] { "MWB", "TRV", "CAR"};

            foreach (Reference lReference in pInputDocument.DeclarationList.Declaration.DeclarationHeader.Reference.Where(x => lCodes.Contains(x.RefCode)))
                Console.WriteLine(lReference.RefText);
        }
    }
}
