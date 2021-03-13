using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitor
{
    public class LatexDocumentPartVisitor : IDocumentPartVisitor
    {
        public StringBuilder Output { get; set; }


        public LatexDocumentPartVisitor()
        {
            Output = new StringBuilder();
        }

        public void VisitBoldText(BoldText boldText)
        {
            Output.Append($"\\textbf{{{boldText.Text}}}");
        }

        public void VisitHyperLink(HyperLink hyperlink)
        {
            Output.Append($"\\href{{{hyperlink.Url}}}{{{hyperlink.Text}}}");
        }

        public void VisitPlainText(PlainText plainText)
        {
            Output.Append(plainText.Text);
        }
    }
}
