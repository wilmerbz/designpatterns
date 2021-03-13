using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class EmptyLineExpression : Expression
    {
        protected override bool InterpretLine(Context context)
        {
            var line = context.Line;
            var isEmpty = string.IsNullOrEmpty(line);

            if (isEmpty)
            {
                context.LineHandled = true;
            }

            return false;
        }
    }
}
