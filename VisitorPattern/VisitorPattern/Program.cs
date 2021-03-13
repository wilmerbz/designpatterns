using System;
using System.Reflection.Metadata;
using VisitorPattern.Elements;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var document = new VisitorPattern.Elements.Document();

            document.DocumentParts.Add(new PlainText() { Text = "Welcome to the " });
            document.DocumentParts.Add(new BoldText() { Text = "Visitor Pattern!" });
            document.DocumentParts.Add(new PlainText() { Text = "For more informationm click " });
            document.DocumentParts.Add(new HyperLink() { Text = "HERE", Url = "https://www.google.com.co/search?q=visitor+pattern" });

            var htmlVisitor = new HTMLDocumentPartVisitor();
            var latexVisitor = new LatexDocumentPartVisitor();

            document.Accept(htmlVisitor);
            document.Accept(latexVisitor);

            Console.WriteLine($"Document HTML:\n{htmlVisitor.Output}");
            Console.WriteLine($"Document Latext:\n{latexVisitor.Output}");
            Console.ReadKey();
        }
    }
}
