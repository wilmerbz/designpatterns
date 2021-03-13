using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class CommentExpression : Expression
    {
        protected override bool InterpretLine(Context context)
        {
            var line = context.Line;

            bool isComment = line.StartsWith("//") || line.StartsWith("/*");

            if (isComment)
            {
                context.LineHandled = true;
            }

            return false;
        }
    }
}
