using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public abstract class Expression : IExpression
    {
        public bool Interpret(Context context)
        {
            bool result = InterpretLine(context);
            if (result)
            {
                context.Size++;
            }
            return result;
        }

        protected abstract bool InterpretLine(Context context);

    }
}
