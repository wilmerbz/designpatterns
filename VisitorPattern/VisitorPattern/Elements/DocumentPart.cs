using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Visitor;

namespace VisitorPattern.Elements
{
    public abstract class DocumentPart
    {

        public string Text { get; set; }

        public abstract void Accept(IDocumentPartVisitor visitor);
    }
}
