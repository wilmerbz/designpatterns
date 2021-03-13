using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Visitor;

namespace VisitorPattern.Elements
{
    public class Document
    {

        public List<DocumentPart> DocumentParts { get; set; }

        public Document()
        {
            DocumentParts = new List<DocumentPart>();
        }

        public void Accept(IDocumentPartVisitor visitor)
        {

            foreach (DocumentPart documentPart in DocumentParts)
            {
                documentPart.Accept(visitor);
            }

        }
    }
}
