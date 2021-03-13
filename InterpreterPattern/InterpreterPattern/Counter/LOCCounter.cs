using InterpreterPattern.Counter.Interpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter
{
    public class LOCCounter
    {
        public IExpression IExpression { get; private set; }

        public CountResult ProcessFile(string[] fileContent)
        {

            var context = new Context(fileContent);

            var expressions = new List<IExpression>() {
                new EmptyLineExpression(),
                new CommentExpression(),
                new ClassExpression(),
                new InterfaceExpression(),
                new EnumExpression(),
                new MethodExpression(),
                new LineExpression()
            };

            while (context.HasNext())
            {
                var line = context.MoveNext();
                for (int expressionIndex = 0; expressionIndex < expressions.Count && !context.LineHandled; expressionIndex++)
                {
                    IExpression expression = expressions[expressionIndex];
                    expression.Interpret(context);
                }
            }

            CountResult result = new CountResult()
            {
                PartName = context.PartName,
                Size = context.Size,
                NumberOfItems = context.ItemsCount
            };


            return result;

        }

    }
}
