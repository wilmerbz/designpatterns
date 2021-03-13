using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Visitor;

namespace VisitorPattern.Elements
{
    public class HyperLink : DocumentPart
    {
        public string Url { get; set; }

        public override void Accept(IDocumentPartVisitor visitor)
        {
            visitor.VisitHyperLink(this);
        }
    }
}
