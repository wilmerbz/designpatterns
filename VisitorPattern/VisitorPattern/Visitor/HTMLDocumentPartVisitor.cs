using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Elements;

namespace VisitorPattern.Visitor
{
    public class HTMLDocumentPartVisitor : IDocumentPartVisitor
    {
        public StringBuilder Output { get; set; }

        public HTMLDocumentPartVisitor()
        {
            Output = new StringBuilder();
        }

        public void VisitBoldText(BoldText boldText)
        {
            Output.Append($"<b>{boldText.Text}</b>");
        }

        public void VisitHyperLink(HyperLink hyperlink)
        {
            Output.Append($"<a href=\"{hyperlink.Url}\">{hyperlink.Text}</a>");
        }

        public void VisitPlainText(PlainText plainText)
        {
            Output.Append(plainText.Text);
        }
    }
}
