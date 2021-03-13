using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public interface IExpression
    {

        bool Interpret(Context context);

    }
}

