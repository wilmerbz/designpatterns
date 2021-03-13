using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class LineExpression : Expression
    {
        protected override bool InterpretLine(Context context)
        {
            context.LineHandled = true;
            return true;
        }
    }
}
