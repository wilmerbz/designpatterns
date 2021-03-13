using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitor
{
    public interface IDocumentPartVisitor
    {
        StringBuilder Output { get; set; }
        void VisitPlainText(PlainText plainText);
        void VisitBoldText(BoldText boldText);
        void VisitHyperLink(HyperLink hyperlink);

    }
}
