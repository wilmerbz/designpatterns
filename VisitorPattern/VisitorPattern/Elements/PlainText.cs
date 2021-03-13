using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Visitor;

namespace VisitorPattern.Elements
{
    public class PlainText : DocumentPart
    {
        public override void Accept(IDocumentPartVisitor visitor)
        {
            visitor.VisitPlainText(this);
        }
    }
}
