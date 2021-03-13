using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class MethodExpression : Expression
    {

        protected override bool InterpretLine(Context context)
        {
            var line = context.Line;

            bool isMethod = false;

            bool haveParameters = line.Length >= 2 && line.Contains("(") && line.EndsWith(")");

            if (haveParameters)
            {
                isMethod = line.Split("(").Length >= 2;
            }

            if (isMethod)
            {
                context.ItemsCount++;
                context.LineHandled = true;
            }

            return isMethod;

        }

    }
}
